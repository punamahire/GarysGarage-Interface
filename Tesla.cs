using System;

namespace GarysGarage
{
    public class Tesla : IElectricVehicle
    {
        public double CurrentChargePercentage { get; } = 100;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 50;
        }
    }
}
