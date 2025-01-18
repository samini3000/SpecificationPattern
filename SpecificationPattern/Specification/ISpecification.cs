namespace SpecificationPattern.Spefication
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
