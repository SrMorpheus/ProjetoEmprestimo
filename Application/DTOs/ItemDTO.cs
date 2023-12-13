namespace Application.DTOs
{
    public class ItemDTO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string Observacao { get; set; }
        public int CodigoCategoria { get; set; }
        public bool Ativo { get; set; }

    }
}
