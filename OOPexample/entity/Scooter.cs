namespace Task1.entity
{
    public class Scooter : Vehicle, @interface.InterfaceInformation
    { 
     private bool IsGlowingWheels { get; set; }

        public Scooter(string nameValue, string modelValue, int horsePowersValue, int maxSpeedValue)
: base(nameValue, modelValue, maxSpeedValue)
    {
     //   Console.WriteLine("Scooter constructor");

        this.IsGlowingWheels = true;
        this.MaxSpeed = 30;
    }

    private void representation()
    {
        base.representation();

        Console.WriteLine("Scooter with Glowing Wheels: " + IsGlowingWheels);
        Console.WriteLine("Max Speed: " + MaxSpeed);
    }

}
}

