using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class UtilizadorConverter : IConverter<Utilizador, UtilizadorVO>, IConverter<UtilizadorVO, Utilizador>
    {
        private readonly UtilizadorEmprestimoConverter _converter;

        public UtilizadorConverter()
        {
            _converter = new();
        }

        public Utilizador Parse(UtilizadorVO origin)
        {
            if (origin == null) return null;

            return new Utilizador
            {
                Id = origin.Id,
                NomeUltilizador = origin.NomeUltilizador,
                Email = origin.Email,
                Telefone = origin.Telefone,
                TipoUtilazdorId = origin.TipoUtilazdorId,
                Ativo = origin.Ativo,
                UltilizadorEmprestimos = _converter.Parse(origin.UltilizadorEmprestimos)
            };
        }

        public List<Utilizador> Parse(List<UtilizadorVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public UtilizadorVO Parse(Utilizador origin)
        {
            if (origin == null) return null;

            return new UtilizadorVO
            {
                Id = origin.Id,
                NomeUltilizador = origin.NomeUltilizador,
                Email = origin.Email,
                Telefone = origin.Telefone,
                TipoUtilazdorId = origin.TipoUtilazdorId,
                Ativo = origin.Ativo,
                UltilizadorEmprestimos = _converter.Parse(origin.UltilizadorEmprestimos)
            };
        }

        public List<UtilizadorVO> Parse(List<Utilizador> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }

  
}

