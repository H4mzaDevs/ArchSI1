using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        private DateTime BirthDate { get; set; }
        private string FirstName { get; set; }

        // Passengers for Seats
        public ICollection<SeatPassenger> SeatPassengers { get; set; }

    }
}
