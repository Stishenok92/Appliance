namespace ApplianceLibrary.Model.Entity
{
    public class Tv : Appliance
    {
        private double Diagonal { get; set; }
        private string MatrixType { get; set; }
        private string MatrixResolution { get; set; }
        private int MatrixFrequency { get; set; }
        private bool SmartTv { get; set; }

        public Tv()
        {
            
        }

        public Tv(string nameProduct, string nameCompany, int power, double diagonal, string matrixType,
            string matrixResolution, int matrixFrequency, bool smartTv) : base(nameProduct, nameCompany, power)
        {
            Diagonal = diagonal;
            MatrixType = matrixType;
            MatrixResolution = matrixResolution;
            MatrixFrequency = matrixFrequency;
            SmartTv = smartTv;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Diagonal: {Diagonal}\n" +
                   $"Matrix type: {MatrixType}\n" +
                   $"Matrix resolution: {MatrixResolution}\n" +
                   $"Matrix frequency: {MatrixFrequency}\n" +
                   $"Matrix smart tv: {SmartTv}\n";
        }
    }
}