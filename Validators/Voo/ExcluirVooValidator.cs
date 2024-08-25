using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesControl.Contexts;
using FluentValidation;

namespace AirlinesControl.Validators.Voo
{
    public class ExcluirVooValidator : AbstractValidator<int>
    {
        private readonly AirlinesControlContext _context;

        public ExcluirVooValidator(AirlinesControlContext context)
        {
            _context = context;

            RuleFor(id => _context.Voos.Find(id))
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Id de voo inválido.")
                .Must(voo => voo!.DataHoraChegada >= DateTime.Now).WithMessage("Não é possível excluir um voo já finalizado.");
        }
    }
}