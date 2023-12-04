namespace Domain.models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string NomeCategoria {get ; set;}

        public List<Item> Itens { get; set;}

    }
}
