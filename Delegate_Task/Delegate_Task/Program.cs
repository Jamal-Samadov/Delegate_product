using System;
using System.Collections.Generic;

namespace Delegate_Task
{
    internal class Program
    {
        public delegate bool Callback(int m);
        public delegate void Sales(int num);
        static void Main(string[] args)
        {
            
            List<Product> products = new List<Product>
            {
                new Product{Name = "Concert ticket", Count=25, Price=50},
            };
                   
            Console.WriteLine("Hello welcome to our Concert place\n");
            

            List<Order> orders = new List<Order>
            {

            };

            Order.TicketSales();
           
        }

        public static int Sum(int[] arr, Callback func)
        {
            int total = default;
            foreach (int num in arr)
            {
                if (func(num))
                {
                    total += num;
                }
            }
            return total;
        }
        

    }
}
