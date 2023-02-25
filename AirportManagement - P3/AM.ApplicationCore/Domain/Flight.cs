using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string destination { get; set; }
        public string departure { get; set; }
        public DateOnly flightDate { get; set; }
        public int flightId { get; set; }
        public string effectiveArrival { get; set; }
        public TimeOnly estimatedDuration { get; set; }
        public virtual List<Passenger> passengers { get; set; }
        public Plane plane;
        
        

        public override string ToString()
        {
            return "Destination: \n" 
                + destination 
                + " Departure: \n" 
                + departure 
                + "Fligh Date: \n" 
                + flightDate.ToString() 
                + "Effective Arrival: \n" 
                + effectiveArrival 
                + "estimatedDuration: \n"
                + estimatedDuration.ToString()
                ;
        }

        public Flight(string destination, DateOnly flightDate, string effectiveArrival, TimeOnly estimatedDuration, List<Passenger> passengers, Plane plane)
        {
            this.destination = destination;
            this.flightDate = flightDate;
            this.effectiveArrival = effectiveArrival;
            this.estimatedDuration = estimatedDuration;
            this.passengers = passengers;
            this.plane = plane;
        }
    }
}
