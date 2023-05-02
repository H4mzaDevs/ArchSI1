using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Plane
    {
        [Key]
        public int PlaneId { get; set; }
        private int Capacity { get; set; }
        private DateTime ManufactureDate { get; set; }

        public enum PlaneType
        {
            Passenger = 0,
            Cargo = 1,
            Military = 2
        }

        // One Plane has Many Seats
        public ICollection<Seat> Seats { get; set; }

    }
}
