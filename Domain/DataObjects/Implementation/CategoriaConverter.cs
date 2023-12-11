using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class CategoriaConverter : IConverter<Categoria, CategoriaVO>, IConverter<CategoriaVO, Categoria>
    {

        private readonly ItemConverter _converter;

        public CategoriaConverter()
        {
            _converter = new ();
            
        }


        public Categoria Parse(CategoriaVO origin)
        {
            if (origin == null) return null;

            return new Categoria
            {
                Id = origin.Id,

                NomeCategoria = origin.NomeCategoria,

                Itens = _converter.Parse(origin.Itens)
            };

        }

        public List<Categoria> Parse(List<CategoriaVO> origin)
        {

            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();

        }

        public CategoriaVO Parse(Categoria origin)
        {
            if (origin == null) return null;

            return new CategoriaVO
            {
                Id = origin.Id,

                NomeCategoria = origin.NomeCategoria,

                Itens = _converter.Parse(origin.Itens)
            };
        }

        public List<CategoriaVO> Parse(List<Categoria> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
