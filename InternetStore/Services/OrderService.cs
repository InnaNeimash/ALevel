using System;
using System.Collections.Generic;
using Models;
using Services;

namespace Services
{
    public class OrderService
    {
        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }
        ProductService productService=new ProductService();
        private readonly object FirstName;
        private readonly object LastName;

        public void CreateOrder() 
        {
            
                StreamWriter sw = new StreamWriter("D:\\apps\\Bill.txt");
                sw.WriteLine("Groceries internet store");
                sw.WriteLine("Bills ID 256");
                sw.WriteLine($"{FirstName} {LastName}");
                sw.WriteLine($"{DateTime.Now}");
                sw.WriteLine("Your order");
                string text = Console.ReadLine();
                sw.Write(text);
                sw.Close();
        }
    }
}
