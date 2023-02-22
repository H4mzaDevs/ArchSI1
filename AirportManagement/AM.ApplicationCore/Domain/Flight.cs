using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    internal class Flight
    {
        private string destination { get; set; }
        private string departure { get; set; }
        private DateOnly flightDate { get; set; }
        private int flightId { get; set; }
        private string effectiveArrival { get; set; }
        private TimeOnly estimatedDuration { get; set; }
        ICollection<Passenger> passengers;
        Plane plane;

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
    }
}
