using cw3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("LISTA KONTENEROW: ");
        Console.WriteLine(" ");
        
        var gas = new GasContainer(1000, 200, 300, 150, 10);
        Console.WriteLine("dane kontenera--------------------------------- ");
        gas.Load(400);
        gas.UnLoad();
        gas.NotifyHazard("Wyciek gazu");
        Console.WriteLine($"maxLoad: {gas.MaxLoad} kg");
        Console.WriteLine($"heigh: {gas.Height} cm");
        Console.WriteLine($"ownWeight: {gas.OwnWeight} kg");
        Console.WriteLine($"depth: {gas.Depth} cm");

        Console.WriteLine(" ");        

        var lq = new LiquidContainer(5000, 300, 400, 100, true);
        Console.WriteLine("dane kontenera--------------------------------- ");
        lq.Load(500);
        lq.UnLoad();
        lq.NotifyHazard("Niebezpieczny ladunek");
        Console.WriteLine($"maxLoad: {lq.MaxLoad} kg");
        Console.WriteLine($"heigh: {lq.Height} cm");
        Console.WriteLine($"ownWeight: {lq.OwnWeight} kg");
        Console.WriteLine($"depth: {lq.Depth} cm");
        
        Console.WriteLine(" ");  
        
        var rf = new RefrigeratedContainer(9000, 400, 300, 150, "apple", 1);
        Console.WriteLine("dane kontenera--------------------------------- ");
        rf.Load(500);
        rf.UnLoad();
        Console.WriteLine($"maxLoad: {rf.MaxLoad} kg");
        Console.WriteLine($"heigh: {rf.Height} cm");
        Console.WriteLine($"ownWeight: {rf.OwnWeight} kg");
        Console.WriteLine($"depth: {rf.Depth} cm");
        Console.WriteLine($"type: apple");
        Console.WriteLine($"temperature: {rf.Temperature} C");
    }
}