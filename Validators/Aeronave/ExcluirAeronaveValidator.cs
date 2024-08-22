using AirlinesControl.Contexts;
using AirlinesControl.ViewModels.Aeronave;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace AirlinesControl.Validators.Aeronave
{
    public class ExcluirAeronaveValidator : AbstractValidator<int>
    {
        private readonly AirlinesControlContext _context;

        public ExcluirAeronaveValidator(AirlinesControlContext context)
        {
            _context = context;

            RuleFor(id => _context.Aeronaves.Include(a => a.Voos).Include(a => a.Manutencoes).FirstOrDefault(a => a.Id == id))
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Id da aeronave inválido")
                .Must(aeronave => aeronave!.Voos.Count == 0).WithMessage("Não é possível excluir uma aeronave que já realizou voos.")
                .Must(aeronave => aeronave!.Manutencoes.Count == 0).WithMessage("Não é possível excluir uma aeronave que já realizou manutenções.");
        }
    }
}