using AirlinesControl.Contexts;
using AirlinesControl.Entities;
using AirlinesControl.ViewModels.Aircraft;

namespace AirlinesControl.Services
{
    public class AeronaveService
    {
        private readonly AirlinesControlContext _context;

        public AeronaveService(AirlinesControlContext context)
        {
            _context = context;
        }

        public DetalharAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)
        {
            var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

            _context.Add(aeronave);
            _context.SaveChanges();

            return new DetalharAeronaveViewModel
            (
                aeronave.Id,
                aeronave.Fabricante,
                aeronave.Modelo,
                aeronave.Codigo
            );
        }
    }
}