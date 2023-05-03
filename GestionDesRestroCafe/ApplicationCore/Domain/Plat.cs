using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Plat
    {
        [StringLength(50, ErrorMessage = " String length 50 charcters !")]
        public string Nom { get; set; }

        [Key]
        public int IdPlat { get; set; }

        public string TypePlat { get; set; }

        public string PhotoPlat { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [Range(40, int.MaxValue, ErrorMessage = "The {0} field must be superior at 40 .")]
        public double Prix { get; set; }

        // Many-To-Many: Commande-Plat
        public ICollection<Commande> Commandes { get; set; } = new List<Commande>();

        // Many-To-Many: Menu-Plat
        public ICollection<Menu> Menus { get; set; } = new List<Menu>();

        // One-To-Many: Plat-LigneCommande
        public ICollection<LigneCommande> LignesCommande { get; set; } = new List<LigneCommande>();
    }

}
