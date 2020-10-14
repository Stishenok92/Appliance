namespace ApplianceProjectLibrary.Model.Entity
{
    public abstract class Appliance
    {
        private string NameProduct { get; set; }
        private string NameCompany { get; set; }
        public int Power { get; set; }

        public Appliance()
        {
            
        }

        public Appliance(string nameProduct, string nameCompany, int power)
        {
            NameProduct = nameProduct;
            NameCompany = nameCompany;
            Power = power;
        }

        public override string ToString()
        {
            return $"Name product: {NameProduct}\n" +
                   $"Name company: {NameCompany}\n" +
                   $"Power: {Power}\n";
        }
    }
}