using EventSourcing.Domain.Models;

namespace EventSourcing.Domain.Specifications
{
    public class VerfiyTransferAccountSpecification : ISpecification<decimal>
    {
        public bool IsSatisfiedBy(decimal valueToTransfer)
        {
            return valueToTransfer > 0;
        }
    }
}
