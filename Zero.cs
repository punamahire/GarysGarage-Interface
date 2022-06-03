using System;

namespace GarysGarage
{
    public class Zero : IElectricVehicle
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 18;
            CurrentChargePercentage = 100;
        }
    }
}