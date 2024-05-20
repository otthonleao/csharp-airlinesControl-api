using AirlinesControl.Entities.Enums;

namespace AirlinesControl.Entities;

public class Maintenance
{
    public Maintenance(DateTime dataHora, MaintenanceType tipo, int aircraftId, string? observacoes = null)
    {
        DataHora = dataHora;
        Observacoes = observacoes;
        Tipo = tipo;
        AircraftId = aircraftId;
    }
    public int Id { get; set; }
    public DateTime DataHora{ get; set;}
    public string? Observacoes { get; set; }
    public MaintenanceType Tipo { get; set; }
    public int AircraftId { get; set; } 
    public Aircraft Aircraft { get; set; } = null!;
}