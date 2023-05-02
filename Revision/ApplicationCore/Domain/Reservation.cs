using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Reservation
    {
        [Key]
        private DateTime DateReservation { get; set; }

        public ICollection<SeatPassenger> SeatPassengers { get; set; }
    }
}
