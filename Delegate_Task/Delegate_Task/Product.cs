using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Task
{
     class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }


        //public Product(string name, int price)
        //{
        //    Name = name;
        //    Price = price;
        //}

        public override string ToString()
        {
            return $"{Name} {Price}";
        }

    }

}
