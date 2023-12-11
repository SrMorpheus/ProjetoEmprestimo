namespace Domain.VOs
{
    public class UtilizadorVO
    {
        public int Id { get; set; }
        public string NomeUltilizador { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int TipoUtilazdorId { get; set; }
        public bool Ativo { get; set;  }

        public List<UltilizadorEmprestimoVO> UltilizadorEmprestimos { get; set; }

    }
}
