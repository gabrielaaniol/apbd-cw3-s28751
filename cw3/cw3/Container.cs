namespace cw3;

public class Container
{
    private static int counter = 1; //dodatkowa zmienna do nadania numeru kontenerowi
    public string SerialNumber { get; set; }
    public double CargoMass { get; set; }
    public double Height { get; set; }
    public double OwnWeight { get; set; }
    public double Depth { get; set; }
    public double MaxLoad { get; set; }

    public Container(string type, double maxLoad, double height, double ownWeight, double depth) //dodatkowa zmienna dla typu kontenera
    {
        SerialNumber = $"KON-{type}-{counter++}";//do nadania typu i numeru
        Height = height;
        OwnWeight = ownWeight;
        Depth = depth;
        MaxLoad = maxLoad;
    }

    public virtual void Load(double weight)
    {
        if (CargoMass + weight > MaxLoad)
        {
            throw new Exception("OverfillException: Przekroczono dopuszczalna ladownosc!!");
        }
        else
        {
            CargoMass += weight;
        }
    }

    public virtual void UnLoad()
    {
        CargoMass = 0;
    }
}