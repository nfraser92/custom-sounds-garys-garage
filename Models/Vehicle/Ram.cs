using System;

namespace customsounds
{
public class Ram : Vehicle, IGasPowered {  // Gas powered truck
    public double FuelCapacity { get; set; }

    public override void Drive () {
        Console.WriteLine($"The {MainColor} Ram makes the sound clunk");
    }

    public override void Turn (string direction) {
        Console.WriteLine($"The {MainColor} Ram turned {direction}");
    }

    public override void Stop () {
        Console.WriteLine($"The {MainColor} Ram braked suddenly");
        Console.WriteLine($"");
    }

    public void RefuelTank () {
        Console.WriteLine($"The {MainColor} Ram is refuelling. It takes {FuelCapacity} gallons.");
    }
}
}