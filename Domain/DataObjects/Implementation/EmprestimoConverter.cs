
using Domain.DataObjects.Contract;
using Domain.models;
using Domain.VOs;

namespace Domain.DataObjects
{
    public class EmprestimoConverter : IConverter<Emprestimo, EmprestimoVO>, IConverter<EmprestimoVO, Emprestimo>
    {
        public readonly UtilizadorEmprestimoConverter _converter;


        public EmprestimoConverter()
        {
            _converter = new();
        }



        public EmprestimoVO Parse(Emprestimo origin)
        {
            if (origin == null) return null;

            return new EmprestimoVO
            {
                Id = origin.Id,
                ItemId = origin.ItemId,
                DataTransacao = origin.DataTransacao,
                Quantidade = origin.Quantidade,
                DataDevolucao = origin.DataDevolucao,
                DescricaoEmprestimo = origin.DescricaoEmprestimo,
                DescricaoDevolucao = origin.DescricaoDevolucao,
                UsuarioId = origin.UsuarioId,
                UltilizadorEmprestimos = _converter.Parse(origin.UltilizadorEmprestimos)

            };


        }

        public List<EmprestimoVO> Parse(List<Emprestimo> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public Emprestimo Parse(EmprestimoVO origin)
        {
            if (origin == null) return null;

            return new Emprestimo
            {
                Id = origin.Id,
                ItemId = origin.ItemId,
                DataTransacao = origin.DataTransacao,
                Quantidade = origin.Quantidade,
                DataDevolucao = origin.DataDevolucao,
                DescricaoEmprestimo = origin.DescricaoEmprestimo,
                DescricaoDevolucao = origin.DescricaoDevolucao,
                UsuarioId = origin.UsuarioId,
                UltilizadorEmprestimos = _converter.Parse(origin.UltilizadorEmprestimos)

            };
        }

        public List<Emprestimo> Parse(List<EmprestimoVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
