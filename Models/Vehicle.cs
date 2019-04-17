using System;

namespace customsounds
{
public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive () {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn (string direction) {
        Console.WriteLine($"The {MainColor} turned {direction}");
    }
    public virtual void Stop () {
        Console.WriteLine($"The {MainColor} came to a halt");
        Console.WriteLine($"");

    }
}
}
