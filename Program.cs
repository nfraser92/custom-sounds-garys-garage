using System;
using System.Collections.Generic;

namespace customsounds
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create an instance of each vehicle.
            Define a different value for each vehicle's properties.
            Create a Drive() method in the Vehicle class.
            Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
             */

            Zero fxs = new Zero()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                BatteryKWh = 20
            };

            Tesla modelS = new Tesla()
            {
                MainColor = "Black",
                MaximumOccupancy = 5,
                BatteryKWh = 500
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "White",
                MaximumOccupancy = 2,
                FuelCapacity = 400
            };

            Ram Dodge = new Ram()
            {
                MainColor = "Orange",
                MaximumOccupancy = 6,
                FuelCapacity = 20
            };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();
            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);

            List<IGasPowered> GasPoweredVehicles = new List<IGasPowered>();
            GasPoweredVehicles.Add(mx410);
            GasPoweredVehicles.Add(Dodge);

            electricVehicles.ForEach(ev => ev.ChargeBattery());
            GasPoweredVehicles.ForEach(gv => gv.RefuelTank());

            fxs.Drive();
            fxs.Turn("Around");
            fxs.Stop();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            Dodge.Drive();
            Dodge.Turn("left");
            Dodge.Stop();

            GasStation PetrolPump = new GasStation();
            BatteryChargingStation elecStop = new BatteryChargingStation();

            PetrolPump.Refuel(GasPoweredVehicles);
            elecStop.Refuel(electricVehicles);
        }
    }
}
