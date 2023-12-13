namespace Application.DTOs
{
    public class EmprestimoDTO
    {
        public int Codigo { get; set; }
        public int CodigoItem { get; set; }
        public DateTime DataTransacao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDevolucao { get; set; }
        public string DescricaoEmprestimo { get; set; }
        public string DescricaoDevolucao { get; set; }
        public int CodigoUsuario { get; set; }



    }
}
