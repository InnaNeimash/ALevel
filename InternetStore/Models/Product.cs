namespace Models
{
    public class Product
    {
        public decimal Price { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public Product(string name, decimal price,int quant)
        {
            NameProduct = name;
            Price = price;
            Quantity = quant;
        }
        public void Print()
        {
            Console.WriteLine($"{NameProduct},{Price},{Quantity}");
        }
    }
}