using AM.ApplicationCore.Domain;
using static AM.ApplicationCore.Domain.Plane;

class Program
{
    static void Main(string[] args)
    {
        Plane p = new Plane();
        p.planetype = planeType.airBus;
        p.capacity = 200;
        p.manufactureDate = new DateOnly(2018, 11, 10);
        Console.WriteLine(p.ToString());
        /* Plane plane2 = new Plane(planeType.boing, 300, new DateOnly(2022,2,22)); */
        Plane plane3 = new Plane
        {
            planetype = planeType.airBus,
            capacity = 150,
            manufactureDate = new DateOnly(2022, 2, 22)
        };
    }
}