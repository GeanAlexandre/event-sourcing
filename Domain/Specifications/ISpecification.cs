namespace EventSourcing.Domain.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);
    }
}
