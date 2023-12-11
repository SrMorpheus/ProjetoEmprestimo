

using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class UsuarioConverter : IConverter<Usuario, UsuarioVO>, IConverter<UsuarioVO, Usuario>
    {

        private readonly EmprestimoConverter _converterEmprestimo;
        private readonly LoginConverter _converterLogin;


        public UsuarioConverter ()
        {

            _converterEmprestimo =  new();
            _converterLogin = new();

        }


        public Usuario Parse(UsuarioVO origin)
        {
            if (origin == null) return null;

            return new Usuario()
            {
                Id = origin.Id,
                NomeUsuario = origin.NomeUsuario,
                Matricula = origin.Matricula,
                Email = origin.Matricula,
                TipoUsuarioId = origin.TipoUsuarioId,
                Telefone = origin.Telefone,
                Ativo = origin.Ativo,
                Emprestimos = _converterEmprestimo.Parse(origin.Emprestimos),
                Logins = _converterLogin.Parse(origin.Logins)

            };

        
    }

        public List<Usuario> Parse(List<UsuarioVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public UsuarioVO Parse(Usuario origin)
        {
            if (origin == null) return null;

            return new UsuarioVO()
            {
                Id = origin.Id,
                NomeUsuario = origin.NomeUsuario,
                Matricula = origin.Matricula,
                Email = origin.Matricula,
                TipoUsuarioId = origin.TipoUsuarioId,
                Telefone = origin.Telefone,
                Ativo = origin.Ativo,
                Emprestimos = _converterEmprestimo.Parse(origin.Emprestimos),
                Logins = _converterLogin.Parse(origin.Logins)

            };
        }

        public List<UsuarioVO> Parse(List<Usuario> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
