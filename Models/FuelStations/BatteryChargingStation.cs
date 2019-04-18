using System;
using System.Collections.Generic;


namespace customsounds
{

    // 1. Create a BatteryStation type for electric-powered vehicles.
    public class BatteryChargingStation : IFuelStation<BatteryChargingStation>
    {
        public int FuelCapacity { get; set; }

        public void Refuel(List<IElectricPowered> vehicles) {
            vehicles.ForEach(v => v.ChargeBattery());
        }
    }
}