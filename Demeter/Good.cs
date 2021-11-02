using System;

namespace Demeter.Good
{
    public class Person
    {
        private IBusinessBrain businessBrain;

        decimal GetPriceOfCoffee(CupOfCoffee cupOfCoffee)
        {
            var baseCostPerCup = cupOfCoffee.GetPricePerCoffee();
            var labourCosts = GetLabourCostPerCoffee();

            var costPerCup = baseCostPerCup + labourCosts;
            
            var markupPercent = businessBrain.GetMarkupPercent();
            
            var markedUpCost = markupPercent * costPerCup;
            return markedUpCost;
        }
        
        private decimal GetLabourCostPerCoffee()
        {
            return 0.35m;
        }
    }

  

    internal class CupOfCoffee
    {
        private CoffeeMachine MachineOfOrigin { get; }

        public decimal GetPricePerCoffee()
        {
            var runningCostPerRefill = MachineOfOrigin.CostOfRunningMachineFromFullToEmpty;
            var copsOfCoffeeMakeAbleBeforeRefill = MachineOfOrigin.CupsOfCoffeeCreatableWithFullBeanReservoir;
            
            var costPerCup = runningCostPerRefill / runningCostPerRefill;
            return costPerCup;
        }
    }

    internal interface IBusinessBrain
    {
        decimal GetMarkupPercent();
    }
    internal class CoffeeMachine
    {
        public decimal CostOfRunningMachineFromFullToEmpty => 300;

        public float CupsOfCoffeeCreatableWithFullBeanReservoir => 50;
    }
}
    
