using Models;
using Services;
using System;
namespace Models
{
    public class Program
    {
        private static readonly object FirstName;
        private static readonly object LastName;

        static bool IsYes(string answer)
        {
            return answer.ToLower() == "y";
        }

        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            OrderService orderService = new OrderService();
            Console.WriteLine("Welcome to the Groceries internet store");
            Console.WriteLine("Please, select an action");
            Console.WriteLine("1 - I want to order product");
            Console.WriteLine("2 - No, thanks");
            int NumberAction = Convert.ToInt32(Console.ReadLine());
            switch (NumberAction)
            {
                case 1: productService.ShowCatalog(); break;
                case 2: break;
            }
            bool yes = false;
            do
            {
                Console.WriteLine("Do you want to add products in the basket? yes/no");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    productService.ShowCatalog();
                    Console.WriteLine("Enter the product number you want to add");
                    int numberproduct = Convert.ToInt32(Console.ReadLine());
                    productService.AddToBasket(numberproduct);
                }
            } while (yes);
                Console.WriteLine("Yor basket");
                productService.ShowBasket();
             Console.WriteLine("Do you want to order? yes/no");
                yes=IsYes(Console.ReadLine());
                if (yes) 
                {
                  Console.WriteLine($"Please, enter your First and Last name {FirstName} {LastName}");
                  Console.ReadLine();
                  Console.WriteLine("Yor order has been successfully completed");
                  Console.WriteLine(DateTime.Now);
                  Console.WriteLine("Your order number 256");
                  orderService.CreateOrder();
                }
        }
    }
} 
