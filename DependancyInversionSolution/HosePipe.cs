namespace DependancyInversion
{
    public class HosePipe : IWaterProvider
    {
        private const int WateringAmount = 10;

        public float GetWater()
        {
            return WateringAmount;
        }
    }
}