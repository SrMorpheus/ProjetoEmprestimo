namespace Domain.VOs
{
    public class EmprestimoVO
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime DataTransacao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string DescricaoEmprestimo { get ; set; }
        public string DescricaoDevolucao { get; set; }
        public int UsuarioId { get; set; }

        public List<UltilizadorEmprestimoVO> UltilizadorEmprestimos { get; set; }


    }
}
