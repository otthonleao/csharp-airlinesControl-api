using AirlinesControl.ViewModels.Aeronave;
using AirlinesControl.ViewModels.Cancelamento;
using AirlinesControl.ViewModels.Piloto;

namespace AirlinesControl.ViewModels.Voo
{
    public class DetalhesVooViewModel
    {
        public DetalhesVooViewModel(int id, string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aeronaveId, int pilotoId)
        {
            Id = id;
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
            DataHoraChegada = dataHoraChegada;
            AeronaveId = aeronaveId;
            PilotoId = pilotoId;
        }

        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }
        public DateTime DataHoraChegada { get; set; }
        public int AeronaveId { get; set; }
        public int PilotoId { get; set; }
        public DetalharAeronaveViewModel? Aeronave { get; set; }
        public DetalhesPilotoViewModel? Piloto { get; set; }
        public DetalhesCancelamentoViewModel? Cancelamento { get; set; }
    }
}