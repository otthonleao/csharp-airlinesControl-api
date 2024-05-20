namespace AirlinesControl.Entities;

public class Aircraft
{
    public Aircraft(string fabricante, string modelo, string codigo)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }
    public int Id { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Codigo { get; set; }
    public ICollection<Maintenance> Maintenances { get; set;} = null!;
    public ICollection<Voo> Voos { get; set;} = null!;
}