namespace DependancyInversion
{
    public class Plant
    {
        private float currentWater;

        public void WaterSelf(IWaterProvider waterProvider)
        {
            currentWater += waterProvider.GetWater();
        }
    }
}