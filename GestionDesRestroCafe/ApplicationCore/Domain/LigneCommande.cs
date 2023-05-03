using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class LigneCommande
    {
        [Key]
        public int Id { get; set; }
        public int Quantite { get; set; }

        // Plat
        public int PlatId { get; set; }
        [ForeignKey("PlatId")]
        public Plat Plat { get; set; }

        // Commande
        public string NumCmd { get; set; }
        [ForeignKey("NumCmd")]
        public Commande Commande { get; set; }
    }
}
