namespace AirlinesControl.Entities;

public class Flight
{
    public Flight(string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aircraftId, int pilotId)
    {
        Origem = origem;
        Destino = destino;
        DataHoraPartida = dataHoraPartida;
        DataHoraChegada = dataHoraChegada;
        AircraftId = aircraftId;
        PilotId = pilotId;
    }

    public int Id { get; set; }
    public string Origem { get; set; }
    public string Destino { get; set; }
    public DateTime DataHoraPartida { get; set; }
    public DateTime DataHoraChegada { get; set; }
    public int AircraftId { get; set; }
    public int PilotId { get; set; }
    public Aircraft Aircraft { get; set; } = null!;
    public Pilot Pilot { get; set; } = null!;
    public Cancellation? Cancellation { get; set; }

}