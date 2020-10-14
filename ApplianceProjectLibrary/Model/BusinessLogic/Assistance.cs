using ApplianceProjectLibrary.Model.Entity;

namespace ApplianceProjectLibrary.Model.BusinessLogic
{
    public class Assistance
    {
        public static double CalculateTotalPower(Basket basket)
        {
            double total = 0;

            for (int i = 0; i < basket.GetCount(); i++)
            {
                total += basket[i].Power;
            }
            
            return total;
        }
    }
}