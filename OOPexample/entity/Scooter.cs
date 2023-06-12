using Task1.@interface;

namespace Task1.entity
{
    public class Scooter : Vehicle, @IInformation
    {
        private int MaxSpeed { get; }
        private bool IsGlowingWheels { get; }
        public Scooter() : base("Scooter", 2)
        {
            MaxSpeed = 150;
            IsGlowingWheels = true;
        }
        override
        public void Representation()
        {
            base.Representation();

            Console.WriteLine("Glowing Wheels:" + IsGlowingWheels + '\n' + "Max Speed:" + MaxSpeed);
            Console.WriteLine("--------------------");
        }

    }

    }


