namespace Domain.models
{
    public class Usuario
    {
     public int Id { get; set; }
     public string NomeUsuario { get; set; }
     public string Matricula { get; set; }
     public string Email { get; set; }
     public int TipoUsuarioId { get; set; }
     public string Telefone { get; set; }
     public bool Ativo { get; set; }
    public List<Emprestimo> Emprestimos { get; set; }

    }
}
