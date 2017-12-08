namespace EventSourcing.Domain.Specifications
{
    public class VerfiyTransferAccountSpecification : CompositeSpecification<decimal>
    {
        public override bool IsSatisfiedBy(decimal valueToTransfer)
        {
            return valueToTransfer > 0;
        }
    }
}
