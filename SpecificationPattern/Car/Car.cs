using SpecificationPattern.Car.CarSpecification;

namespace SpecificationPattern.Car
{
    public class Car
    {
        public int MaxSpeed { get; private set; }
        public string Color { get; private set; }
        
        private Car() { }

        private Car(int maxSpeed, string color)
        {
            MaxSpeed = maxSpeed;
            Color = color;
        }

        public Car CreateCar(int maxSpeed, string color)
        {
            var car = new CheckCarColor()
                .And(new CheckCarSpeed());
            
            car.IsSatisfiedBy(this);

            return new Car(maxSpeed, color);
        }
    }
}
