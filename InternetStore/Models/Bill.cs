namespace Models
{  
    public class Bill
    { 
       public string ID {  get; set; }
       const string Shopname = "Groceries internet store";
       public decimal TotalPrice { get; set; }
       public DateTime DateTime { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
    }
}