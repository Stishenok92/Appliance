namespace ApplianceProjectLibrary.Model.Entity
{
    public class Kettle : Appliance
    {
        private bool MaintainingTemperature { get; set; }
        private double MaxVolume { get; set; }
        private string BodyMaterial { get; set; }
        private string FlaskMaterial { get; set; }
        private string Color { get; set; }

        public Kettle()
        {
            
        }

        public Kettle(string nameProduct, string nameCompany, int power, bool maintainingTemperature, double maxVolume,
            string bodyMaterial, string flaskMaterial, string color) : base(nameProduct, nameCompany, power)
        {
            MaintainingTemperature = maintainingTemperature;
            MaxVolume = maxVolume;
            BodyMaterial = bodyMaterial;
            FlaskMaterial = flaskMaterial;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Maintaining temperature: {MaintainingTemperature}\n" +
                   $"Volume: {MaxVolume}\n" +
                   $"Body material: {BodyMaterial}\n" +
                   $"Flask material: {FlaskMaterial}\n" +
                   $"Color: {Color}\n";
        }
    }
}