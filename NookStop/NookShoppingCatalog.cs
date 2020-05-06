using System;
using System.Collections.Generic;

namespace NookStop
{
    public class NookShoppingCatalog
    {
        public static List<SpecialGoodsItem> items = new List<SpecialGoodsItem>()
        {
            new SpecialGoodsItem("Lifeguard chair", 1000, 1),
            new SpecialGoodsItem("Utility pole", 1000, 10),
            new SpecialGoodsItem("Shell bed", 1500, 0),
            new SpecialGoodsItem("K.K. Western", 3200, 5),
            new SpecialGoodsItem("Nook Inc Aloha Shirt", 280, 30),
        };

        public static void SpendBells(IslandResident islandResident)
        {
            Console.WriteLine("Please select an item from the catalog:");
            Console.WriteLine(" ");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

            var selectedItem = Console.ReadLine();
            
            foreach (var item in items)
            {
                if (selectedItem == item.Name)
                {
                    if (islandResident.Bells < item.Price)
                    {
                        Console.WriteLine("Oh, it seems you haven't enough bells to buy that item. Take a stroll around the island and see if you can find a money tree!");
                        Menu.ShowMenu();
                        break;
                    }

                    if (item.ItemsLeft == 0)
                    {
                        Console.WriteLine("Oh, we're sorry. That item is no longer available. You have to act fast before items sell out.");
                        SpendBells(islandResident);
                        break;
                    }

                    Console.WriteLine("Your order has been placed! Your order will be delivered shortly to your home through the mail.");
                    islandResident.Bells -= item.Price;
                    Menu.ShowMenu();
                }
            }

        }
    }
}