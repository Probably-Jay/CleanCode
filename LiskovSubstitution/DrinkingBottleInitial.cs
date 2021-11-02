namespace LiskovSubstitution
{
    public class DrinkingBottleInitial
    {
        public bool Open { get; protected set; }
        public float AmountFull { get; protected set; }
        

        public void TakeOffLid()
        {
            Open = true;
        }

        public void PutLidBackOn()
        {
            Open = false;
        }

        public void Drink(int sips)
        {
            if (Open)
            {
                AmountFull--;
            }
        }
    }
}