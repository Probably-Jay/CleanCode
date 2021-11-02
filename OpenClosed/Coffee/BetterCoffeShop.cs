namespace OpenClosed
{
    public class BetterCoffeeShop
    {
        private CoffeePriceProviderFactory coffeePriceProviderFactory;
        
        void OrderCoffee(Client client, Coffee coffee)
        {
            var priceProvider = coffeePriceProviderFactory.GetProviderByCustomerAccountType(client.AccountType);

            var totalCost = priceProvider.GetPrice(coffee);

            client.Charge(totalCost);
        }
    }
}