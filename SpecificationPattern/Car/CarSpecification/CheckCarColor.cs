using SpecificationPattern.Spefication;

namespace SpecificationPattern.Car.CarSpecification
{
    public class CheckCarColor : Specification<Car>
    {
        public override bool IsSatisfiedBy(Car entity)
        {
            if (entity.Color == null)
                throw new ArgumentNullException();
            return true;
        }
    }
}
