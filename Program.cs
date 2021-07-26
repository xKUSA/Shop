using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your product: ");
            string product = Console.ReadLine();
            Console.Write("Enter your town: ");
            string town = Console.ReadLine();
            Console.Write("Enter quantity: ");
            double quantity = Convert.ToDouble(Console.ReadLine());
            if (town == "Sofia" && product == "Coffe")
            {
                Console.WriteLine(quantity * 0.50);
            }
            else if (town == "Sofia" && product == "Water")
            {
                Console.WriteLine(quantity * 0.80);
            }
            else if (town == "Sofia" && product == "Beer")
            {
                Console.WriteLine(quantity * 1.20);
            }
            else if (town == "Sofia" && product == "Sweets")
            {
                Console.WriteLine(quantity * 1.45);
            }
            else if (town == "Sofia" && product == "Peanuts")
            {
                Console.WriteLine(quantity * 1.60);
            }
            else if (town == "Plovdiv" && product == "Coffe")
            {
                Console.WriteLine(quantity * 0.40);
            }
            else if (town == "Plovdiv" && product == "Water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (town == "Plovdiv" && product == "Beer")
            {
                Console.WriteLine(quantity * 1.15);
            }
            else if (town == "Plovdiv" && product == "Sweets")
            {
                Console.WriteLine(quantity * 1.30);
            }
            else if (town == "Plovdiv" && product == "Peanuts")
            {
                Console.WriteLine(quantity * 1.50);
            }
            else if (town == "Varna" && product == "Coffe")
            {
                Console.WriteLine(quantity * 0.45);
            }
            else if (town == "Varna" && product == "Water")
            {
                Console.WriteLine(quantity * 0.70);
            }
            else if (town == "Varna" && product == "Beer")
            {
                Console.WriteLine(quantity * 1.10);
            }
            else if (town == "Varna" && product == "Sweets")
            {
                Console.WriteLine(quantity * 1.35);
            }
            else if (town == "Varna" && product == "Peanuts")
            {
                Console.WriteLine(quantity * 1.55);
            }


        }
    }
}
