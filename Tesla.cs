using System;

namespace garys_garage
{
  public class Tesla: Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past. Zoomzoomzoooooom!");
    }
    public override void Turn (string direction)
    {
        Console.WriteLine($"The {MainColor} Tesla skirts {direction}.");
    }
}
}