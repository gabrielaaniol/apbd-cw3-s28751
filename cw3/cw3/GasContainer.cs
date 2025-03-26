namespace cw3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double maxLoad, double height, double ownWeight, double deepth, double pressure)
        : base("G", maxLoad, height, ownWeight, deepth)
    {
        Pressure = pressure;
    }

    public override void UnLoad()
    {
        CargoMass *= 0.05; //zostawiam 5% gazu w kotenetzre
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {message} - {SerialNumber}");
    }
}