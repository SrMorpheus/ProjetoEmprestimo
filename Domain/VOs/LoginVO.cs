namespace Domain.VOs
{
    public class LoginVO
    {
        public  int Id { get; set; }
        public string Matricula { get; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public int UsuarioId { get; set; };

    }
}
