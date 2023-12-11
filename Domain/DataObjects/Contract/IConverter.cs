namespace Domain.DataObjects.Contract
{
    public interface IConverter <O, D>
    {
        D Parse(O origin);

        List<D> Parse(List<O> origin);


    }
}
