namespace DependancyInversion
{
    public class WateringCan
    {
        private const int DefaultWateringAmount = 10;
        private float remainingWater;
        
        public float PourWater()
        {
            var wateringAmount = GetWateringAmount();
            
            remainingWater -= wateringAmount;
            return wateringAmount;
        }

        private float GetWateringAmount()
        {
            if (remainingWater > DefaultWateringAmount)
                return DefaultWateringAmount;
            else
                return remainingWater;
        }
    }
}