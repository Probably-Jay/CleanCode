namespace DependancyInversion.initial
{
    public class Plant
    {
        private float currentWater;

        public void WaterSelf(WateringCan wateringCan)
        {
            currentWater += wateringCan.PourWater();
        }
    }
}