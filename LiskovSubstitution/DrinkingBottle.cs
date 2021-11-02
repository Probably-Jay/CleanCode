namespace LiskovSubstitution
{
    public class DrinkingBottle
    {
        public virtual bool Open { get; protected set; }
        public float AmountFull { get; protected set; }
        

        public virtual void TakeOffLid()
        {
            Open = true;
        }

        public virtual void PutLidBackOn()
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