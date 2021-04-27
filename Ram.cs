using System;

namespace garys_garage
{
  public class Ram: Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past. Brappppppp!");
    }
    public override void Stop()
    {
        Console.WriteLine($"The Ram screeches to a halt.");
    }
}
}