using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateMenu { get; set; }

        // Many To Many - Menu Plat
        public ICollection<Plat> Plats { get; set; } = new List<Plat>();
    }
}
