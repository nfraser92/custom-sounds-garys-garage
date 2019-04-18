using System;

namespace customsounds
{

public class Tesla : Vehicle, IElectricPowered {
    public double BatteryKWh { get; set; }

    public override void Drive () {
        Console.WriteLine($"The {MainColor} Tesla makes the sound neeeeeeuuuuuum!");
    }
    public override void Turn (string direction) {
        Console.WriteLine($"The {MainColor} Tesla turned {direction}");
    }
    public override void Stop () {
        Console.WriteLine($"The {MainColor} Tesla ground to a halt");
        Console.WriteLine($"");
    }

    public void ChargeBattery () {
        Console.WriteLine($"The {MainColor} Tesla is refuelling. It takes {BatteryKWh}KWh to charge.");
     }
}
}