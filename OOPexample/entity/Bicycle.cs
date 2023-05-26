using Task1.@interface;

namespace Task1.entity
{
    public class Bicycle : Vehicle, @IInformation
    {
        private int MaxSpeed { get; set; }
        private int MaxValueOfPassengers { get; set; }


        public Bicycle() : base("Bicycle", 2)
        {
            MaxSpeed = 100;
            MaxValueOfPassengers = 1;
        }
        override
        public void Representation()
        {
            base.Representation();

            Console.WriteLine("Max Value Of Passengers:" + MaxValueOfPassengers + '\n' + "Max Speed:" + MaxSpeed);
            Console.WriteLine("--------------------");
        }

    }
}
