namespace EventSourcing.Domain.Specifications
{
    public static class SpecificationExtensionMethods
    {
        public static ISpecification<TEntity> And<TEntity>(
          this ISpecification<TEntity> specificationOne,
          ISpecification<TEntity> specificationTwo)
            => new AndSpecification<TEntity>(
              specificationOne, specificationTwo);

        public static ISpecification<TEntity> Or<TEntity>(
          this ISpecification<TEntity> specificationOne,
          ISpecification<TEntity> specificationTwo)
            => new OrSpecification<TEntity>(
              specificationOne, specificationTwo);

        public static ISpecification<TEntity> Not<TEntity>(
          this ISpecification<TEntity> specification)
            => new NotSpecification<TEntity>(specification);
    }
}
