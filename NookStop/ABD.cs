using System;

namespace NookStop
{
    public class ABD
    {
        public static void Savings(IslandResident islandResident)
        {
            Console.WriteLine($"You have {islandResident.Bells} bells in your savings.");
        }

        public static void Deposit(int amount, IslandResident islandResident)
        {
            if (amount > 0)
            {
                islandResident.Bells += amount;
                Console.WriteLine("");
                Console.WriteLine($"We added {amount} bells to your savings.");
            }
            else
            {
                Console.WriteLine("Please enter an amount larger than 0.");
            }
        }
    }
}