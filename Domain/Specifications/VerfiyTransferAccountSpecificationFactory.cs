namespace EventSourcing.Domain.Specifications
{
    public class VerfiyTransferAccountSpecificationFactory : ISpecificationFactory<decimal>
    {
        public ISpecification<decimal> Factory() => new VerfiyTransferAccountSpecification();
    }
}
