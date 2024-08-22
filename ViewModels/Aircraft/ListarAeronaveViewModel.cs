namespace AirlinesControl.ViewModels.Aircraft
{
    public class ListarAeronaveViewModel
    {
        public ListarAeronaveViewModel(int id, string modelo, string codigo)
        {
            Id = id;
            Modelo = modelo;
            Codigo = codigo;
        }

        private int Id { get; set; }
        public string Modelo { get; set;}
        public string Codigo { get; set;}
    }
}