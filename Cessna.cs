using System;

namespace GarysGarage
{
    public class Cessna : IGasVehicle
    {
        public double CurrentTankPercentage { get; } = 100;
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 50;
        }
    }
}