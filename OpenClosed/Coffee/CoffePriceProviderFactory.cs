using System.Collections.Generic;

namespace OpenClosed
{
    public class CoffeePriceProviderFactory
    {
        private IReadOnlyDictionary<AccountType, ICoffeePriceProvider> providers;

        public CoffeePriceProviderFactory()
        {
            providers = new Dictionary<AccountType, ICoffeePriceProvider>()
            {
                {AccountType.Customer, new DefaultCoffeePriceProvider()},
                {AccountType.Employee, new EmployeeCoffeePriceProvider()},
                {AccountType.Owner, new OwnerCoffeePriceProvider()}
            };
        }
        
        public ICoffeePriceProvider GetProviderByCustomerAccountType(AccountType accountType)
        {
            return providers[accountType];
        }
        
    }
}