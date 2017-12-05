namespace EventSourcing.Domain.Specifications
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _leftSpecification;
        private readonly ISpecification<T> _rightSpecification;

        public AndSpecification(ISpecification<T> leftSpecification, ISpecification<T> rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;

        }

        public bool IsSatisfiedBy(T o)
        {
            return _leftSpecification.IsSatisfiedBy(o) && _rightSpecification.IsSatisfiedBy(o);
        }
    }
}
