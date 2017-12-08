namespace EventSourcing.Domain.Specifications
{
    public interface ISpecificationFactory<T>
    {
        ISpecification<T> Factory();
    }
}
