namespace Domain.VOs
{
    public class HistoricoEmailVO
    {

        public int Id { get; set; }
        public int UltilazadorEmprestimoId { get; set; }
        public DateTime DataEnvio { get; set; }
        public string Titulo { get; set; }
        public string Assunto { get; set; }


    }
}
