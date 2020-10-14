namespace ApplianceProjectLibrary.Model.Entity
{
    public class Fridge : Appliance
    {
        private string CoolingSystem { get; set; }
        private int VolumeOverall { get; set; }
        private int VolumeUseful { get; set; }
        private int NoiseLevel { get; set; }
        private string Color { get; set; }

        public Fridge()
        {
            
        }

        public Fridge(string nameProduct, string nameCompany, int power, string coolingSystem, int volumeOverall,
            int volumeUseful, int noiseLevel, string color) : base(nameProduct, nameCompany, power)
        {
            CoolingSystem = coolingSystem;
            VolumeOverall = volumeOverall;
            VolumeUseful = volumeUseful;
            NoiseLevel = noiseLevel;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Cooling system: {CoolingSystem}\n" +
                   $"Volume overall: {VolumeOverall}\n" +
                   $"Volume useful: {VolumeUseful}\n" +
                   $"Noise level: {NoiseLevel}\n" +
                   $"Color: {Color}\n";
        }
    }
    
    
}