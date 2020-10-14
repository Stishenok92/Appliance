using ApplianceProjectLibrary.Model.Entity;
using System;
using ApplianceProjectLibrary.Model.BusinessLogic;

namespace ApplianceProjectLibrary.Controller
{
    public class Controller
    {
        static void Main(string[] args)
        {
            Appliance app1 = new Fridge("Washer", "Samsung", 750, "SamsungStore", 150, 180, 75, "White");

            Appliance app2 = new Kettle("Kettle", "Xiaomi", 100, true, 6, "Plastic", "Plastic", "White");

            Appliance app3 = new Tv("TV", "Samsung", 400, 55, "IPS", "4K", 60, true);

            Appliance app4 = new Washer("Washer", "Asus", 40, 7, 1500, 14, 45, 74);

            Basket basket = new Basket();
            basket.Add(app1);
            basket.Add(app2);
            basket.Add(app3);
            basket.Add(app4);
            Console.WriteLine(basket);
            Console.WriteLine(Assistance.CalculateTotalPower(basket));
        }
    }
}