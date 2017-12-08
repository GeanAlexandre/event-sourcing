namespace EventSourcing.Domain.Specifications
{
    public class AccountSpecificationAbstractFactory : IAccountSpecificationAbstractFactory
    {
        public ISpecificationFactory<decimal> VerfiyTransferAccountSpecification => new VerfiyTransferAccountSpecificationFactory();
    }
}
