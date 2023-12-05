namespace Domain.models
{
    public class Login
    {
        public  int Id { get; set; }
        public string Matricula { get; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public int UsuarioId;

    }
}
