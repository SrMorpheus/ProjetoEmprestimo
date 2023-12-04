namespace Domain.models
{
    public class TipoUtilizador
    {
        public int Id { get; set; }

        public string NomeTipo { get; set; }

        public List<Utilizador> utilizadores { get; set; }



    }
}
