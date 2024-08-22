using AirlinesControl.Contexts;
using AirlinesControl.Entities;
using AirlinesControl.ViewModels.Aircraft;

namespace AirlinesControl.Services
{
    public class AeronaveService(AirlinesControlContext context)
    {
        private readonly AirlinesControlContext _context = context;

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

        public IEnumerable<ListarAeronaveViewModel> ListarAeronaves()
        {
            return _context.Aeronaves.Select(a => new ListarAeronaveViewModel(a.Id, a.Modelo, a.Codigo));
        }

            public DetalharAeronaveViewModel? ListarAeronavePeloId(int id)
    {
        var aeronave = _context.Aeronaves.Find(id);

        if (aeronave != null)
        {
            return new DetalharAeronaveViewModel
            (
                aeronave.Id, 
                aeronave.Fabricante, 
                aeronave.Modelo, 
                aeronave.Codigo
            );
        }

        return null;
    }
    }
}