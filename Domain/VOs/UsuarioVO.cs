

namespace Domain.VOs
{
    public class UsuarioVO
    {
     public int Id { get; set; }
     public string NomeUsuario { get; set; }
     public string Matricula { get; set; }
     public string Email { get; set; }
     public int TipoUsuarioId { get; set; }
     public string Telefone { get; set; }
     public bool Ativo { get; set; }
    public List<EmprestimoVO> Emprestimos { get; set; }
    public List<LoginVO> Logins { get; set;  }

    }
}
