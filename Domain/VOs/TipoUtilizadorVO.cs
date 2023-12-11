namespace Domain.VOs
{
    public class TipoUtilizadorVO
    {
        public int Id { get; set; }

        public string NomeTipo { get; set; }

        public List<UtilizadorVO> utilizadores { get; set; }



    }
}
