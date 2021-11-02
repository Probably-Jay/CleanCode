using System;
using System.Collections.Generic;
using System.Linq;

namespace Calisthenics1and6
{
    public class ManyLine
    {
        private List<Customer> customers;

        Person GetTallestPersonInHouseShorterThanCustomer(int customerIndex)
        {
            var customer = customers[customerIndex];
            var customerInfo = customer.CustomerInfo;
            var address = customerInfo.Address;
            var occupants = address.GetOccupants();

            var tallerThanCustomer = occupants.Where(occupant => occupant.height.HasValue)
                .Where(occupant => occupant.height.Value < customerInfo.height.Value)
                .OrderBy(occupant => occupant.height)
                .Last();
            
            return tallerThanCustomer;
        }
    }
}