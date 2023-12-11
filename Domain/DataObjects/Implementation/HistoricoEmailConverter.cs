using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class HistoricoEmailConverter : IConverter<HistoricoEmail, HistoricoEmailVO>, IConverter<HistoricoEmailVO, HistoricoEmail>
    {
        public HistoricoEmail Parse(HistoricoEmailVO origin)
        {

            if (origin == null) return null;

            return new HistoricoEmail
            {
                Id = origin.Id,
                UltilazadorEmprestimoId = origin.UltilazadorEmprestimoId,
                DataEnvio = origin.DataEnvio,
                Titulo = origin.Titulo,
                Assunto = origin.Assunto
            };


        }

        public List<HistoricoEmail> Parse(List<HistoricoEmailVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
        

        public HistoricoEmailVO Parse(HistoricoEmail origin)
        {
            if (origin == null) return null;

            return new HistoricoEmailVO
            {
                Id = origin.Id,
                UltilazadorEmprestimoId = origin.UltilazadorEmprestimoId,
                DataEnvio = origin.DataEnvio,
                Titulo = origin.Titulo,
                Assunto = origin.Assunto
            };

        }

        public List<HistoricoEmailVO> Parse(List<HistoricoEmail> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
