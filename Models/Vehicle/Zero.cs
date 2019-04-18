using System;

namespace customsounds
{
    public class Zero : Vehicle, IElectricPowered
{  // Electric motorcycle
    public double BatteryKWh { get; set; }

     public override void Drive () {
        Console.WriteLine($"The {MainColor} Zero makes the sound brrrroooooooom!");
    }
     public override void Stop () {
        Console.WriteLine($"The {MainColor} Zero came to a stop");
        Console.WriteLine($"");
    }

    public override void Turn (string direction) {
        Console.WriteLine($"The {MainColor} Zero turned {direction}");
    }

    public void ChargeBattery () {
        Console.WriteLine($"The {MainColor} Zero vehicle is charging. It takes {BatteryKWh}KWh to charge fully.");
    }

}
}