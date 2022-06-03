using System;

namespace GarysGarage
{
    public class Tesla : IElectricVehicle
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 50;
            CurrentChargePercentage = 100;
        }
    }
}
