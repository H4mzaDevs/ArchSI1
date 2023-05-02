using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The Name field must contain at least 1 character.")]
        private string Name { get; set; }

        // One Section has many Seats
        public ICollection<Seat> Seats { get; set; }
    }
}
