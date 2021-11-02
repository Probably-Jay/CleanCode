using System;

namespace LiskovSubstitution
{
    public class BeerBottle : DrinkingBottle
    {
        public float ABV { get; }
        
        public override void PutLidBackOn()
        {
            throw new Exception("Beer bottle's can't put lids back on");
        }
    }
}