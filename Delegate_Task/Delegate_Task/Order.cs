using System;
using System.Collections.Generic;
using System.Text;
using static Delegate_Task.Program;

namespace Delegate_Task
{
    internal class Order
    {
        public string Products;
        public int TotalPrice { get; set; }
        public int Date;

      public static bool TicketSales(int[] arr, Callback func)
        {
            int pr = 50;
            if(pr > 100 && pr > 200)
            {
                Console.WriteLine(pr + 50 / 10);
            }
            return default;
        }

        public static void TicketSales()
        {
            int selection = Convert.ToInt32(Console.ReadLine());
            int number = 90;
            if (number + selection <= 100)
            {
                int tick = (int)number + selection;
                Console.WriteLine(number + selection + " Sold out " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
            else if (number + selection >= 100 && number + selection <= 200)
            {
                int tick = (int)number + selection / 10;
                Console.WriteLine(number + selection + " Sold out and 10% discount applied" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
            else if (number + selection <= 200)
            {
                int tick = (int)number + selection / 20;
                Console.WriteLine(number + selection + " Sold out and 20% discount applied" + " " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            }
            else
            {
                Console.WriteLine("Please write correct type");
            }

        }
    }
}
