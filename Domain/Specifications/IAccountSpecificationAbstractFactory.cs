namespace EventSourcing.Domain.Specifications
{
    public interface IAccountSpecificationAbstractFactory
    {
        ISpecificationFactory<decimal> VerfiyTransferAccountSpecification { get; }
    }
}
