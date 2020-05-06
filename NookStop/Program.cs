using System;

namespace NookStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var bells = 2000;
            
            NookShoppingCatalog nookShoppingCatalog = new NookShoppingCatalog();
            ABD abd = new ABD();
            IslandResident islandResident = new IslandResident(bells);

            Menu.ShowMenu();
            
            while (true)
            {
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.WriteLine("How many bells would you like to deposit?");
                        int.TryParse(Console.ReadLine(), out var amount);
                        ABD.Deposit(amount, islandResident);
                        Menu.ShowMenu();
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("Welcome to Nook Shopping!");
                        Console.WriteLine("Order special goods or goods from the daily selection here.");
                        Console.WriteLine("");
                        NookShoppingCatalog.SpendBells(islandResident);
                        break;
                    case "3":
                        ABD.Savings(islandResident);
                        Menu.ShowMenu();
                        break;
                    default:
                        Console.WriteLine("Please select option 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}