using System;
using System.Collections.Generic;


namespace customsounds
{

    // 2. Create a GasStation type for gas-powered vehicles.
    public class GasStation : IFuelStation<IGasPowered>
    {
        public int FuelCapacity { get; set; }

        public void Refuel(List<IGasPowered> vehicles) {
            vehicles.ForEach(v => v.RefuelTank());
        }
    }
}