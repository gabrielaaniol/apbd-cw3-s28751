namespace cw3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }

    public LiquidContainer( double maxLoad, double height, double ownWeight, double depth, bool idHazardous)
        : base("L", maxLoad, height, ownWeight, depth)
    {
        IsHazardous = idHazardous;
    }

    public override void Load(double weight)
    {
        double limit = IsHazardous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (weight > limit)
        {
            NotifyHazard("Niebezpieczna operacja: przekroczono limit!!");
            throw new Exception("OverfillException");
        }
        
        base.Load(weight);
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"[ALERT] {message} - {SerialNumber}");
    }
}