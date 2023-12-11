namespace Domain.VOs
{
    public class TipoUsuarioVO
    {
        public int Id { get; set; }
        public string NomeTipo { get; set;}
        public List<UsuarioVO> Usuarios { get; set;}
    }
}
