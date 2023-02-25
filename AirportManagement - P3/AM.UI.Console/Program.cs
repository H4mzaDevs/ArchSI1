using AM.ApplicationCore.Domain;
using static AM.ApplicationCore.Domain.Plane;
using AM.ApplicationCore.Services;

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
            manufactureDate = new DateOnly(2022, 2, 21)
        };

        ServiceFlight sf = new ServiceFlight();
        sf.Flights = testData.listFlights;
        List < Plane > lp = testData.listPlanes;


        List<DateOnly> fd = sf.GetFlightDates("Paris");
        Console.WriteLine("**  Liste des dates pour la destination Paris **");
        for (int j = 0; j < fd.Count; j++)
        {
            Console.WriteLine(fd[j].ToString());
        }
        sf.GetFlights("Destination", "Paris");
        Console.WriteLine("\n\n");
        sf.ShowFlightDetails(lp[0]);
        Console.WriteLine("\n\n Flight Days Number");
        Console.WriteLine(sf.ProgrammedFlightNumber(new DateOnly(2022, 1, 1)));
        Console.WriteLine("\n\n Average Duration Paris");
        Console.WriteLine(sf.DurationAverage("Paris"));
       /* IEnumerable<Flight> od = sf.OrderedDurationFlights; */


    }
}