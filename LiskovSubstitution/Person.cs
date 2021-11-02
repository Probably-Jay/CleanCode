namespace LiskovSubstitution
{
    public class Person
    {
        void Drink(DrinkingBottle drink)
        {
            if(!drink.Open)
            {
                drink.TakeOffLid();
            }
            
            drink.Drink(1);


            drink.PutLidBackOn();
        }

 
        
    }
}