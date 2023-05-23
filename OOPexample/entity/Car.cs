namespace Task1.entity
{
    public class Car : Vehicle, @interface.InterfaceInformation
    {
        private int HorsePowers { get; set; }

        public Car(string nameValue, string modelValue, int horsePowersValue, int maxSpeedValue)
    : base(nameValue, modelValue, maxSpeedValue)
        {
            //   Console.WriteLine("Car constructor");

            this.HorsePowers = 75;
            this.MaxSpeed= 150;

        }

        private void representation()
        {
            base.representation();

            Console.WriteLine("Horse Powers: " + HorsePowers);
            Console.WriteLine("Max Speed: " + MaxSpeed);
        }

    }
}

