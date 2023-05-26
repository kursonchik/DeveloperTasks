using System.Diagnostics;
using Task1.@interface;

namespace Task1.entity
{
    public class Car : Vehicle, @IInformation

    {
        private int MaxSpeed { get; set; }
        private int Doors { get; set; }

        public Car() : base("Car", 4)
        {
            MaxSpeed = 150;
            Doors = 4;
        }
        override
        public void Representation()
        {
            base.Representation();

            Console.WriteLine("Doors:" + Doors + '\n' + "Max Speed:" + MaxSpeed);
            Console.WriteLine("--------------------");
        }

    }
    

}


