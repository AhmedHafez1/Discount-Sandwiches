using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountSandwiches
{
    class MenuItem
    {
        public static Random Randomizer = new Random();

        public string[] Proteins = { "Chicken", "Beef", "Eggs",
            "Fish", "Beans", "Salamon" };
        public string[] Condiments = { "yellow mustard", "brown mustard",
        "honey mustard", "mayo", "relish" };
        public string[] Breads = { "Toast", "white", "Fino", "Bread", "Shami" };

        public string Description = "";
        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            Description = $"{randomProtein} with {randomCondiment} on {randomBread}";

            decimal bucks = Randomizer.Next(2, 5);
            decimal cents = Randomizer.Next(1, 98);
            decimal price = bucks + (cents * 0.01M);

            Price = price.ToString("c");
        }
    }
}
