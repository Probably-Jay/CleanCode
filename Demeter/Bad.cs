using System;

namespace Demeter
{
    public class Person
    {
        private IBusinessBrain businessBrain;
        
        decimal GetPriceOfCoffee(Coffee coffee)
        {
            var machineCoffeeWasMadeWith = coffee.MachineOfOrigin;
            var runningCostBeforeRefill = machineCoffeeWasMadeWith.CostOfRunningMachineFromFullToEmpty;
            var copsOfCoffeeMakeAbleBeforeRefill = machineCoffeeWasMadeWith.CupsOfCoffeeCreatableWithFullBeanReservoir;

            var labourCosts = GetLabourCostPerCoffee();
            
            var costPerCup = runningCostBeforeRefill / runningCostBeforeRefill + labourCosts;

            var markupPercent = businessBrain.GetMarkupPercent();
            var markedUpCost = markupPercent * costPerCup;

            return markedUpCost;
        }

        private decimal GetLabourCostPerCoffee()
        {
            return 0.35m;
        }
    }

 

    internal class Coffee
    {
        public CoffeeMachine MachineOfOrigin { get; }
    }

    internal class CoffeeMachine
    {
        public decimal CostOfRunningMachineFromFullToEmpty => 300;

        public float CupsOfCoffeeCreatableWithFullBeanReservoir => 50;
    }
    
    internal interface IBusinessBrain
    {
        decimal GetMarkupPercent();
    }
}