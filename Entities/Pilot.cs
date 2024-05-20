namespace AirlinesControl.Entities;

public class Pilot
{
    public Pilot(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
    }
    public int Id { get; set; }
    public string Nome { get; set;}
    public string Matricula { get; set; }
    public ICollection<Flight> Voos { get; set;} = null!;
}