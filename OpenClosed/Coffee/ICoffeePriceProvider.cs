namespace OpenClosed
{
    public interface ICoffeePriceProvider
    {
        decimal GetPrice(Coffee coffee);
    }
    
    
    
    class DefaultCoffeePriceProvider : ICoffeePriceProvider
    {
        public decimal GetPrice(Coffee coffee)
        {
            return coffee.Price;
        }
    }
    
    class EmployeeCoffeePriceProvider : ICoffeePriceProvider
    {
        private const decimal EmployeeDiscount = 0.75m;
        public decimal GetPrice(Coffee coffee)
        {
            return coffee.Price * EmployeeDiscount;
        }
    }

    class OwnerCoffeePriceProvider : ICoffeePriceProvider
    {
        public decimal GetPrice(Coffee coffee)
        {
            return 0;
        }
    }
}