namespace Domain.models
{
    public class UltilizadorEmprestimo
    {
        public int Id { get; set; }
        public int EmprestimoId { get; set; }
        public int UtilizadorId { get; set; }

        public List<HistoricoEmail> HistoricoEmails { get; set; }

    }
}
