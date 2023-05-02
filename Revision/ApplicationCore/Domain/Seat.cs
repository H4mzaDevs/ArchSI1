using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Domain
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The Name field must contain at least 1 character.")]
        private string Name { get; set; }
        private string SeatNumber { get; set; }

        [Range(1, 20, ErrorMessage = "The Size field must be a positive number with a maximum value of 20.")]
        private int Size { get; set; }

        // Seats for one plane
        [ForeignKey("PlaneFK")]
        public int PlaneId { get; set; }

        [InverseProperty("Seats")]
        public Plane Plane { get; set; }


        // Seats for one Section
        [ForeignKey("SectionFK")]
        public int SectionId { get; set; }
        public Section Section { get; set; }

        // Seats for Passengers
        public ICollection<SeatPassenger> SeatPassengers { get; set; }


    }
}
