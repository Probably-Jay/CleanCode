using DependancyInversion;

namespace DependancyInversion
{
    public class WateringCan : IWaterProvider
    {
        private const int DefaultWateringAmount = 10;
        private float remainingWater;
        
        public float GetWater()
        {
            var wateringAmount = GetWateringAmount();
            
            remainingWater -= wateringAmount;
            return wateringAmount;
        }

        private float GetWateringAmount()
        {
            return remainingWater > DefaultWateringAmount ? DefaultWateringAmount : remainingWater;
        }
    }
}