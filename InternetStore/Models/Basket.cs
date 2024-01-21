namespace Models
{
    public class Basket
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string NameProduct { get; set; }
        
        public Basket(string name, decimal price,int quant)
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