using System.Reflection;
using Task1.@interface;

namespace Task1.entity
{
    public abstract class Vehicle
    {
        public string Name { get; }
        public int Wheels { get; }

        public Vehicle(string nameValue, int wheelsValue)
        {
            this.Name = nameValue;

            this.Wheels = wheelsValue;

        }
        public virtual void Representation()
        {
            Console.WriteLine("Type:" + Name + '\n' + "Wheels:" + Wheels);

        }
    }
}
