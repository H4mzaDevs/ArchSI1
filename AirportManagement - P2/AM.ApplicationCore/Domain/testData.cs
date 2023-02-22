using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Domain
{
    public class testData
    {
        public static Plane p1 = new Plane(planeType.boing, 150, new DateOnly(2015, 03, 02));
        public static Plane p2 = new Plane(planeType.airBus, 250, new DateOnly(2020, 11, 11));

        public static Staff s1 = new Staff("captain", "captain", "Captain.captain@gmail.com", new DateOnly(1995, 1, 1), new DateOnly(1999, 1, 1), 99999);
        public static Staff s2 = new Staff("hostess1", "hostess1", "hostess1.hostess1@gmail.co\r\n\r\nm", new DateOnly(1995, 1, 1), new DateOnly(2020, 1, 1), 999);
        public static Staff s3 = new Staff("hostess2", "hostess2", "hostess2.hostess2@gmail.co\r\n\r\nm", new DateOnly(1995, 1, 1), new DateOnly(2020, 1, 1), 999);

        public static Traveller t1 = new Traveller("Traveller1", "Traveller1", "Traveller1.Traveller1@gmail.com", new DateOnly(1980, 1, 1), "No troubles", "American");
        public static Traveller t2 = new Traveller("Traveller2", "Traveller2", "Traveller2.Traveller2@gmail.com", new DateOnly(1981, 1, 1), "Some troubles", "French");
        public static Traveller t3 = new Traveller("Traveller3", "Traveller3", "Traveller3.Traveller3@gmail.com", new DateOnly(1982, 1, 1), "No troubles", "Tunisian");
        public static Traveller t4 = new Traveller("Traveller4", "Traveller4", "Traveller4.Traveller4@gmail.com", new DateOnly(1983, 1, 1), "Some troubles", "American");
        public static Traveller t5 = new Traveller("Traveller5", "Traveller5", "Traveller5.Traveller5@gmail.com", new DateOnly(1984, 1, 1), "Some troubles", "Spanich");

        public static Flight f1 = new Flight("Paris", new DateOnly(2022, 1, 1), "01/01/2022", new TimeOnly(110), new List<Passenger> {s1,s2,s3,t1,t2,t3,t4,t5}, p2);
        public static Flight f2 = new Flight("Paris", new DateOnly(2022, 1, 2), "01/02/2022", new TimeOnly(105), null, p1);
        public static Flight f3 = new Flight("Paris", new DateOnly(2022, 1, 3), "01/03/2022", new TimeOnly(100),  null, p1);
        public static Flight f4 = new Flight("Madrid", new DateOnly(2022, 1, 4), "01/04/2022", new TimeOnly(130), null, p1);
        public static Flight f5 = new Flight("Madrid", new DateOnly(2022, 1, 5), "01/05/2022", new TimeOnly(105), null, p1);
        public static Flight f6 = new Flight("Lisbonne", new DateOnly(2022, 1, 6), "01/06/2022", new TimeOnly(200), null, p2);

        public static List<Flight> listFlights = new List<Flight>{f1,f2,f3,f4,f5,f6};
        public static List<Plane> listPlanes = new List<Plane> { p1, p2 };
    }
}
