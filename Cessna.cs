using System;

namespace garys_garage
{
  public class Cessna: Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna drives past. Neeeeeowww!");
    }
    public override void Stop()
    {
        Console.WriteLine($"The Cessna rolls down the runway for a mile and stops.");
    }
}
}