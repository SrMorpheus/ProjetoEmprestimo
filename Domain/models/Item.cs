namespace Domain.models
{
    public class Item
    {
        public int Id { get; set; }
        public string NomeItem { get ; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string Obervacao { get; set; }
        public int CategoriaId { get; set; }

        public List<Emprestimo> emprestimos { get; set; }
        public bool Ativo { get; set; }

    }
}
