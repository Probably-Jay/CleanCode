using System;

namespace LiskovSubstitution
{
    public class Cup : DrinkingBottle
    {
        public override bool Open => true;

        public override void TakeOffLid() { }

        public override void PutLidBackOn()
        {
            throw new Exception("Cups don't have lids to put on");
        }
    }
}