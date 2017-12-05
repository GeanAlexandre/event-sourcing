namespace EventSourcing.Domain.Specifications
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _notSpeficiation;

        public NotSpecification(ISpecification<T> notSpecification)
        {
            _notSpeficiation = notSpecification;
        }

        public bool IsSatisfiedBy(T o)
        {
            return !_notSpeficiation.IsSatisfiedBy(o);
        }
    }
}
