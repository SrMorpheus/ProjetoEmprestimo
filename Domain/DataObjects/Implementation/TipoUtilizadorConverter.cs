using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class TipoUtilizadorConverter : IConverter<TipoUtilizador, TipoUtilizadorVO>, IConverter<TipoUtilizadorVO, TipoUtilizador>
    {

        private readonly UtilizadorConverter _converter;

        public TipoUtilizadorConverter()
        {
            _converter = new();
        }

        public TipoUtilizadorVO Parse(TipoUtilizador origin)
        {
            if (origin == null) return null;

            return new TipoUtilizadorVO
            {
                Id = origin.Id,
                NomeTipo = origin.NomeTipo,
                utilizadores = _converter.Parse(origin.utilizadores)

            };
        }

        public List<TipoUtilizadorVO> Parse(List<TipoUtilizador> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public TipoUtilizador Parse(TipoUtilizadorVO origin)
        {
            if (origin == null) return null;

            return new TipoUtilizador
            {
                Id = origin.Id,
                NomeTipo = origin.NomeTipo,
                utilizadores = _converter.Parse(origin.utilizadores)

            };
        }

        public List<TipoUtilizador> Parse(List<TipoUtilizadorVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
