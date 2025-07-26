using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Lab2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> transactions = new List<decimal>();

                Console.WriteLine("=== Transaction Filter ===");
                Console.WriteLine("Enter 20 transaction amounts (decimal values):");

                while (transactions.Count < 20)
                {
                    Console.Write($"Transaction #{transactions.Count + 1}: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount >= 0)
                    {
                        transactions.Add(amount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive decimal number.");
                    }
                }

                var largeTransactions = transactions.Where(t => t > 10000).ToList();
                decimal total = largeTransactions.Sum();

                Console.WriteLine("\n=== Transactions Above 10,000 ===");
                if (largeTransactions.Count == 0)
                {
                    Console.WriteLine("No transactions above 10,000.");
                }
                else
                {
                    foreach (var t in largeTransactions)
                    {
                        Console.WriteLine($"₱{t:F2}");
                    }
                    Console.WriteLine($"\nTotal of large transactions: ₱{total:F2}");
                }
            
        }
    }

}
