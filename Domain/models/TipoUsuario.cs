namespace Domain.models
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string NomeTipo { get; set;}
        public List<Usuario> Usuarios { get; set;}
    }
}
