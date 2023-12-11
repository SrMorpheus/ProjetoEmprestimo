using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class TipoUsuarioConverter : IConverter<TipoUsuario, TipoUsuarioVO>, IConverter<TipoUsuarioVO, TipoUsuario>
    {

        private readonly UsuarioConverter _converter;


        public TipoUsuarioConverter()
        {
            _converter = new();

        }

        public TipoUsuario Parse(TipoUsuarioVO origin)
        {
            if (origin == null) return null;

            return new TipoUsuario
            {
                Id = origin.Id,
                NomeTipo = origin.NomeTipo,
                Usuarios = _converter.Parse(origin.Usuarios)
            };
        }

        public List<TipoUsuario> Parse(List<TipoUsuarioVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public TipoUsuarioVO Parse(TipoUsuario origin)
        {
            if (origin == null) return null;

            return new TipoUsuarioVO
            {
                Id = origin.Id,
                NomeTipo = origin.NomeTipo,
                Usuarios = _converter.Parse(origin.Usuarios)
            };
        }

        public List<TipoUsuarioVO> Parse(List<TipoUsuario> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
