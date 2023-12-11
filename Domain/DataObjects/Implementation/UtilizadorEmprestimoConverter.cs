using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class UtilizadorEmprestimoConverter : IConverter<UltilizadorEmprestimo, UltilizadorEmprestimoVO>, IConverter<UltilizadorEmprestimoVO, UltilizadorEmprestimo>
    {

        private readonly HistoricoEmailConverter _converter;

        public UtilizadorEmprestimoConverter()
        {
            _converter = new();
        }

        public UltilizadorEmprestimo Parse(UltilizadorEmprestimoVO origin)
        {
            if (origin == null) return null;

            return new UltilizadorEmprestimo
            {
                Id = origin.Id,
                EmprestimoId = origin.EmprestimoId,
                UtilizadorId = origin.UtilizadorId,
                HistoricoEmails = _converter.Parse(origin.HistoricoEmails)
            };


        }

        public List<UltilizadorEmprestimo> Parse(List<UltilizadorEmprestimoVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public UltilizadorEmprestimoVO Parse(UltilizadorEmprestimo origin)
        {
            if (origin == null) return null;

            return new UltilizadorEmprestimoVO
            {
                Id = origin.Id,
                EmprestimoId = origin.EmprestimoId,
                UtilizadorId = origin.UtilizadorId,
                HistoricoEmails = _converter.Parse(origin.HistoricoEmails)
            };
        }

        public List<UltilizadorEmprestimoVO> Parse(List<UltilizadorEmprestimo> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
