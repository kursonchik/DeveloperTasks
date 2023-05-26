using Task1.@interface;

namespace Task1.entity
{
    public class Motorbike : Vehicle, @IInformation
    {
        private int MaxSpeed { get; }
        private string SidecarForMotorbike { get; }
        public Motorbike() : base("Motorbike", 2)
        {
            MaxSpeed = 150;
            SidecarForMotorbike = "\"java\"";
        }
        override
        public void Representation()
        {
            base.Representation();

            Console.WriteLine("Name of Sidecar For Motorbike:" + SidecarForMotorbike + '\n' + "Max Speed:" + MaxSpeed);
            Console.WriteLine("--------------------");
        }



    }
}
