namespace EventSourcing.Domain.Specifications
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public OrSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(T o)
        {
            return _leftSpecification.IsSatisfiedBy(o) || _rightSpecification.IsSatisfiedBy(o);
        }
    }
}
