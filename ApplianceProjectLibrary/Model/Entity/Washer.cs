namespace ApplianceProjectLibrary.Model.Entity
{
    public class Washer : Appliance
    {
        private double MaxWeight { get; set; }
        private int MaxSpinSpeed { get; set; }
        private int NumberOfProgram { get; set; }
        private int MaxVolume { get; set; }
        private int NoiseLevel { get; set; }

        public Washer()
        {
            
        }

        public Washer(string nameProduct, string nameCompany, int power, double maxWeight, int maxSpinSpeed,
            int numberOfProgram, int maxVolume, int noiseLevel) : base(nameProduct, nameCompany, power)
        {
            MaxWeight = maxWeight;
            MaxSpinSpeed = maxSpinSpeed;
            NumberOfProgram = numberOfProgram;
            MaxVolume = maxVolume;
            NoiseLevel = noiseLevel;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Max weight: {MaxWeight}\n" +
                   $"Max spin speed: {MaxSpinSpeed}\n" +
                   $"Number of program: {NumberOfProgram}\n" +
                   $"Max volume: {MaxVolume}\n" +
                   $"Noise level: {NoiseLevel}\n";
        }
    }
}