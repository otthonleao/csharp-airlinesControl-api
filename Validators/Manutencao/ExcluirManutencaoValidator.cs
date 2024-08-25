using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlinesControl.Contexts;
using FluentValidation;

namespace AirlinesControl.Validators.Manutencao
{
    public class ExcluirManutencaoValidator : AbstractValidator<int>
    {
        private readonly AirlinesControlContext _context;

        public ExcluirManutencaoValidator(AirlinesControlContext context)
        {
            _context = context;

            RuleFor(id => _context.Manutencoes.Find(id))
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Id da manutenção inválido.")
                .Must(manutencao => manutencao!.DataHora > DateTime.Now).WithMessage("Não é possível excluir uma manutenção já realizada.");
        }
    }
}