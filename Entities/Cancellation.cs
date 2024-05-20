namespace AirlinesControl.Entities;

public class Cancellation
{
    public Cancellation(string motivo, DateTime dataHoraNotificacao, int vooId)
    {
        Motivo = motivo;
        DataHoraNotificacao = dataHoraNotificacao;
        VooId = vooId;
    }
    public int Id { get; set; }
    public string Motivo { get; set; }
    public DateTime DataHoraNotificacao { get; set; }
    public int VooId { get; set; }
    public Voo Voo { get; set; } = null!;
}