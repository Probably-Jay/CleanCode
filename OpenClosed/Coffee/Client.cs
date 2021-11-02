namespace OpenClosed
{
    public class Client
    {
        public AccountType AccountType { get; set; }

        public void Charge(decimal totalCost)
        { }
    }
    
    public class Coffee
    {
        public decimal Price { get; }
    }

    public enum AccountType
    {
        Customer
        ,Employee
        ,Owner
        
    }
}