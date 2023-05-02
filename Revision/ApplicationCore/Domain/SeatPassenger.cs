using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class SeatPassenger
    {
        [ForeignKey("SeatFK")]
        public int SeatId { get; set; }

        [ForeignKey("PassengerFK")]
        public int PassengerId { get; set; }

        // Navigation properties
        public Seat Seat { get; set; }
        public Passenger Passenger { get; set; }
    }
}
