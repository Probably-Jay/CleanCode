using System;
using System.Collections.Generic;
using System.Linq;

namespace Calisthenics1and6
{
    public class OneLine
    {
        private List<Customer> customers;

        Person GetTallestPersonInHouseShorterThanCustomer(int customerIndex)
        {
            var occupants = customers[customerIndex].CustomerInfo.Address.GetOccupants();
            
            var tallerThanCustomer = occupants.Where(occupant => occupant.height.HasValue)
                .Where(occupant => occupant.height.Value <
                                   customers[customerIndex]
                                       .CustomerInfo.height.Value)
                .Max();
            return tallerThanCustomer;
        }
    }
}