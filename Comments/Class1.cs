using System;

namespace Comments
{
    public class Class1
    {
        // Time since start-up, expressed in hours
        private float elapsedTime; 
        
        private float elapsedTimeSinceStartUpInHours;


        int AddCustomerAccount(Customer customer)
        {
            // customer is eligible for premium account
            if (customer.IsEligableForPremiumAccount)
            {
                AddPremiumAccount(customer);
                return 0;
            }


            return GenerateActionWasUnsuccessfulCode(); // action was unsuccessful

        }


#region Hidden
        private int GenerateActionWasUnsuccessfulCode() => -1;
#endregion

        
#region Memb
        
        private void AddPremiumAccount(Customer customer)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    internal class Customer
    {
#region Prop
        public bool IsEligableForPremiumAccount => Age > 25 && creditScore > 20;
#endregion
        
        public int creditScore;
        public int Age { get; set; }
    }
}