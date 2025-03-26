namespace cw3;

public class RefrigeratedContainer : Container
{
    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(double maxLoad, double height, double ownWeight, double depth, string productType,
        double temperature)
        : base("C", maxLoad, height, ownWeight, depth)
    {
        ProductType = productType;
        Temperature = temperature;
    }
}