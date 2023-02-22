using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int capacity { get; set; }
        public DateOnly manufactureDate { get; set; }
        public int planeId { get; set; }
        public enum planeType
        {
            boing = 1,
            airBus = 1
        }
        public planeType planetype { get; set; }
        ICollection<Flight> flights;

        public override string ToString()
        {
            return "** This is a Plane ** \ncapacity: \n" + capacity + "\n" + "manufactureDate: \n" + manufactureDate.ToString() + "\n"
                + "planetype : \n"
                + planetype + "\n"
                ;
        }

        public Plane()
        {
            this.capacity = 0;
            this.manufactureDate = new DateOnly();
            this.planeId = 0;
            this.planetype= planeType.boing;
            this.flights = new List<Flight>();
        }

       public Plane(planeType pt, int cap, DateOnly date)
        {
            planetype = pt;
            capacity = cap;
            manufactureDate = date;
        }

    }
}
