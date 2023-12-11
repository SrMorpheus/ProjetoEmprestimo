using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class ItemConverter : IConverter<Item, ItemVO>, IConverter<ItemVO, Item>
    {
        private readonly EmprestimoConverter _converter;

        public ItemConverter()
        {
            _converter = new();

        }

        public Item Parse(ItemVO origin)
        {
            if (origin == null) return null;

            return new Item
            {
                Id = origin.Id,
                NomeItem = origin.NomeItem,
                QuantidadeTotal = origin.QuantidadeTotal,
                QuantidadeDisponivel = origin.QuantidadeDisponivel,
                Obervacao = origin.Obervacao,
                CategoriaId = origin.CategoriaId,
                emprestimos = _converter.Parse(origin.emprestimos),
                Ativo = origin.Ativo

            };
        }

        public List<Item> Parse(List<ItemVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public ItemVO Parse(Item origin)
        {
            if (origin == null) return null;

            return new ItemVO
            {
                Id = origin.Id,
                NomeItem = origin.NomeItem,
                QuantidadeTotal = origin.QuantidadeTotal,
                QuantidadeDisponivel = origin.QuantidadeDisponivel,
                Obervacao = origin.Obervacao,
                CategoriaId = origin.CategoriaId,
                emprestimos = _converter.Parse(origin.emprestimos),
                Ativo = origin.Ativo

            };
        }

        public List<ItemVO> Parse(List<Item> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
