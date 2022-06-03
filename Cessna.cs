using System;

namespace GarysGarage
{
    public class Cessna : IGasVehicle
    {
        public double CurrentTankPercentage { get; set; }
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 50;
            CurrentTankPercentage = 100;
        }
    }
}