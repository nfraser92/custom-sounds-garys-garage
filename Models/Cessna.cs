
using System;

namespace customsounds
{
public class Cessna : Vehicle {  // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public override void Drive () {
        Console.WriteLine($"The {MainColor} Cessna makes the sound screeeech");
    }

    public override void Turn (string direction) {
        Console.WriteLine($"The {MainColor} Cessna turned {direction}");
    }

    public override void Stop () {
        Console.WriteLine($"The {MainColor} Cessna rolled to a stop.");
        Console.WriteLine($"");
    }

    public void RefuelTank () {

     }
}
}