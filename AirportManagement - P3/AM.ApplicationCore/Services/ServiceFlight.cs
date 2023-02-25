using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; }
        public List<DateOnly> GetFlightDates(string destination)
        {
            /* List<DateOnly> ls = new List<DateOnly>();
            /* List<DateOnly> ls = new List<DateOnly>();
             for (int j = 0; j < Flights.Count; j++)
                 if (Flights[j].destination.Equals(destination))
                     ls.Add(Flights[j].flightDate);
             return ls;*/
            /*List<DateOnly> ls = new List<DateOnly>();
            foreach (Flight f in Flights)
                if (f.destination.Equals(destination))
                    ls.Add(f.flightDate);
            return ls;*/
            IEnumerable<DateOnly> req = from f in Flights
                                        where f.destination.Equals(destination)
                                        select f.flightDate;
            return req.ToList();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> lf = new List<Flight>();
            if (filterType.Equals("Destination"))
            {
                foreach (Flight f in Flights)
                {
                    if (f.destination.Equals(filterValue))
                    {
                        Console.WriteLine(f.ToString());
                    }
                }
            }
            if (filterType.Equals("Departure"))
            {
                foreach (Flight f in Flights)
                {
                    if (f.departure.Equals(filterValue))
                    {
                        Console.WriteLine(f.ToString());
                    }
                }
            }
            if (filterType.Equals("FlightDate"))
            {
                foreach (Flight f in Flights)
                {
                    if (f.flightDate.ToString().Equals(filterValue))
                    {
                        Console.WriteLine(f.ToString());
                    }
                }
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            foreach (Flight f in Flights)
            {
                if(f.plane == plane)
                {
                    Console.WriteLine(f.ToString());
                }
            }
        }

        public int ProgrammedFlightNumber(DateOnly startDate)
        {
            var req = from f in Flights
                      where f.flightDate.CompareTo(startDate) > 0 && (f.flightDate.DayNumber - startDate.DayNumber) < 7
                      select f;
            return req.Count();
        }

        public double DurationAverage(string destination)
        {
            int s=0;
            int i = 0;
            foreach(Flight f in Flights)
            {
                if (f.destination.Equals(destination))
                {
                    Console.WriteLine(f.estimatedDuration);
                    s = s + f.estimatedDuration.Hour;
                    i = i + 1;
                }
            }
            return s / i;
        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var req = from f in Flights
                      orderby f.estimatedDuration descending
                      select f;
            return req;
        }

        public IEnumerable<String> SeniorTravellers(Flight f)
        {
            var oldTravellers = from p in f.passengers.OfType<Traveller>()
                                orderby p.birthDate
                                select p.nationality;
            return oldTravellers.Take(3);
            //if we want to skip 3
            //return oldTravellers.Skip(3);
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var req = from f in Flights
                      group f by f.destination;
            foreach (var g in req)
            {
                Console.WriteLine("Destination: " + g.Key);
                foreach (var f in g)
                    Console.WriteLine("Décollage: " + f.flightDate);
            }
            return req;
        }

        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;

        public ServiceFlight()
        {
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = ShowFlightDetails;
        }
        
}
}
