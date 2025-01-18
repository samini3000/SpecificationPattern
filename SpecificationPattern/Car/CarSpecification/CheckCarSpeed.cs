using SpecificationPattern.Spefication;

namespace SpecificationPattern.Car.CarSpecification
{
    public class CheckCarSpeed : Specification<Car>
    {
        public override bool IsSatisfiedBy(Car entity)
        {
            if (entity.MaxSpeed <= 100)
                throw new Exception("Invalid Speed");
            return true;
        }
    }
}
