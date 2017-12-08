namespace EventSourcing.Domain.Specifications
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _notSpeficiation;

        public NotSpecification(ISpecification<T> notSpecification)
        {
            _notSpeficiation = notSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return !_notSpeficiation.IsSatisfiedBy(o);
        }
    }
}
