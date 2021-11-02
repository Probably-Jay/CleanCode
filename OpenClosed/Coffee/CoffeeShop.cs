namespace OpenClosed
{
    public class CoffeeShop
    {
        void OrderCoffee(Client client, Coffee coffee)
        {
            decimal totalCost;
            if (client.AccountType == AccountType.Owner)
            {
                // owner does not pay
                totalCost = 0;
            }
            else if (client.AccountType == AccountType.Employee)
            {
                // employee discount
                totalCost = coffee.Price * 0.75m; 
            }
            else
            {
                totalCost = coffee.Price;
            }

            client.Charge(totalCost);
        }
    }

  
}