using System;

namespace DependancyInversion
{
    public class PlantNiave
    {
        private float currentWater;

        public void WaterSelf(object waterProvider)
        {
            if (waterProvider is WateringCan)
            {
                currentWater += ((WateringCan)waterProvider).PourWater();
            }
            else if (waterProvider is HosePipe)
            {
                currentWater += ((HosePipe)waterProvider).SprayWater();
            }
            else
                throw new NotSupportedException($"Type of {waterProvider} is not supported");
            
        }
    }
}