using AirlinesControl.Contexts;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace AirlinesControl.Validators.Piloto
{
    public class ExcluirPilotoValidator: AbstractValidator<int>
{
    private readonly AirlinesControlContext _context;
    public ExcluirPilotoValidator(AirlinesControlContext context)
    {
        _context = context;

        RuleFor(id => _context.Pilotos.Include(p => p.Voos).FirstOrDefault(p => p.Id == id))
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage("Id do piloto inválido")
            .Must(piloto => piloto!.Voos.Count == 0).WithMessage("Não é possível excluir um piloto que já realizou voos.");
    }
}
}