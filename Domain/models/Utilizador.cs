namespace Domain.models
{
    public class Utilizador
    {
        public int Id { get; set; }
        public string NomeUltilizador { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int TipoUtilazdorId { get; set; }
        public bool Ativo { get; set;  }

        public List<UltilizadorEmprestimo> UltilizadorEmprestimos { get; set; }

    }
}
