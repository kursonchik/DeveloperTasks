namespace Task1.entity
{
    public class Bicycle : Vehicle, @interface.InterfaceInformation
    {
        private int MaxValueOfPassengers { get; set; }
        public Bicycle(string nameValue, string modelValue, int maxSpeedValue, int maxValueOfPassengers) : base(nameValue, modelValue, maxSpeedValue)
        {
         //   Console.WriteLine("Bicycle constructor");

            this.MaxValueOfPassengers = 1;
        }

        private void representation()
        {
            base.representation();

            Console.WriteLine("Max value of passengers: " + MaxValueOfPassengers);
        }
    }
}
