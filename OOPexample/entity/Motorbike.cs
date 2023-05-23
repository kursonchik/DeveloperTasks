namespace Task1.entity
{
    public class Motorbike : Vehicle, @interface.InterfaceInformation
    {
        private string SidecarForMotorbike { get; set; }

        public Motorbike(string nameValue, string modelValue, int horsePowersValue, int maxSpeedValue)
    : base(nameValue, modelValue, maxSpeedValue)
        {
            //  Console.WriteLine("Motorbike constructor");

            this.SidecarForMotorbike = "java";
            this.MaxSpeed = 130;
        }

        private void representation()
        {
            base.representation();

            Console.WriteLine("sidecar For Motorbike: " + SidecarForMotorbike);
            Console.WriteLine("Max Speed: " + MaxSpeed);
        }

    }
}
