namespace Domain.VOs
{
    public class UltilizadorEmprestimoVO
    {
        public int Id { get; set; }
        public int EmprestimoId { get; set; }
        public int UtilizadorId { get; set; }

        public List<HistoricoEmailVO> HistoricoEmails { get; set; }

    }
}
