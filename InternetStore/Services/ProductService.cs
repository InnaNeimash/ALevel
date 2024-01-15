using System;
using System.Collections.Generic;
using Models;

namespace Services
{
    public class ProductService
    {
        public decimal TotalSum;
        public List<Product> Products;
        public List<Product> Nbasket;
        public ProductService()
        {
            Products = new List<Product>
            {
                new ("Bread", 25, 1),
                new ("Milk", 20, 1),
                new ("Cheese", 260, 1),
                new ("Whater", 20, 1),
                new ("Juice", 55, 1),
                new ("Meat", 425, 1),
                new ("Sausages", 21, 1),
                new ("10 Eegs", 65, 1),
                new ("Sour Cream", 55, 1),
                new ("Butter", 65, 1),
                new ("Sunflower oil", 45, 1),
                new ("Olive oil", 285, 1),
                new ("Tomato paste", 10, 1),
                new ("Fish", 450, 1),
                new ("Ham", 650, 1)
            };
            Nbasket = new List<Product>();
        }
        public void AddToBasket(int numberproduct)
        {
            Nbasket.Add(Products[numberproduct - 1]);
            Console.WriteLine($"Product{Products[numberproduct - 1].NameProduct} successfully added to Basket");
            Console.WriteLine($"There are {Nbasket.Count} products");
        }
        public void ShowCatalog()
        {
            Console.WriteLine("Products catalog");
            Console.WriteLine("Name products,Price,Quantity");
            int number = 1;
            foreach (Product product in Products)
            {
                Console.Write(number + ". ");
                product.Print();
                number++;
            }
        }
        public void ShowBasket()
        {
            Console.WriteLine("Products basket");
            int number = 1;
            foreach (Product product in Nbasket)
            {
                Console.Write(number + ". ");
                product.Print();
                TotalSum += product.Price;
                number++;
            }
            Console.WriteLine($"Total price {TotalSum} UAH");
        }
    }
}