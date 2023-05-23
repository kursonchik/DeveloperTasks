using Task1.@interface;

namespace Task1.entity
{
    public class Vehicle : InterfaceInformation
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle(string nameValue, string modelValue, int maxSpeedValue)
        {
            this.Name = nameValue;
            this.Model = modelValue;
            this.MaxSpeed = maxSpeedValue;

          //  Console.WriteLine("Vehicle constructor");

        }

        public void representation()
        {
            Console.WriteLine("Brand: " + Name);
            Console.WriteLine("Model: " + Model);
            
        }

        public override bool Equals(object? obj)
        {
            return obj is Vehicle vehicle &&
                   Name == vehicle.Name &&
                   Model == vehicle.Model &&
                   MaxSpeed == vehicle.MaxSpeed;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Model, MaxSpeed);
        }
    }
}
