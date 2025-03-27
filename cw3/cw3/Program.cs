using cw3;

class Program
{
    static void Main(string[] args)
    {
        var gas = new GasContainer(1000, 200, 300, 150, 10);
        gas.Load(400);
        gas.UnLoad();
        gas.NotifyHazard("Wyciek gazu");

        var liquid = new LiquidContainer(5000, 300, 400, 100, true);
        liquid.Load(500);
        liquid.UnLoad();
        liquid.NotifyHazard("liquid");
    }
}