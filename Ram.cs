using System;

namespace GarysGarage
{
    public class Ram : IGasVehicle
    {
        public double CurrentTankPercentage { get; set; }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 26;
            CurrentTankPercentage = 100;
        }
    }
}