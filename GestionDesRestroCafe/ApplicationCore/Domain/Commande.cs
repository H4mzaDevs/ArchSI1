using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Commande
    {
        [Key]
        public string NumCmd { get; set; }

        [Column("DateCommande")]
        public DateTime DateCmd { get; set; }

        public bool Livree { get; set; }

        // Many To Many - Commande Plat
        public ICollection<Plat> Plats { get; set; } = new List<Plat>();


        public int LivreurId { get; set; }
        [ForeignKey("LivreurId")]
        public Livreur Livreur { get; set; }

        public ICollection<LigneCommande> LignesCommande { get; set; }


    }
}
