namespace Domain.VOs
{
    public class CategoriaVO
    {
        public int Id { get; set; }

        public string NomeCategoria {get ; set;}

        public List<ItemVO> Itens { get; set;}

    }
}
