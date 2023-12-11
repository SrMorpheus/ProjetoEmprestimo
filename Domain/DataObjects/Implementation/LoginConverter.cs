using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class LoginConverter : IConverter<Login, LoginVO>, IConverter<LoginVO, Login>
    {
        public Login Parse(LoginVO origin)
        {
            if (origin == null) return null;

            return new Login
            {

                Id = origin.Id,
                Matricula = origin.Matricula,
                LoginUsuario = origin.LoginUsuario,
                Senha = origin.Senha,
                UsuarioId = origin.UsuarioId

            };

        }

        public List<Login> Parse(List<LoginVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public LoginVO Parse(Login origin)
        {
            return new LoginVO
            {

                Id = origin.Id,
                Matricula = origin.Matricula,
                LoginUsuario = origin.LoginUsuario,
                Senha = origin.Senha,
                UsuarioId = origin.UsuarioId

            };
        }

        public List<LoginVO> Parse(List<Login> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
