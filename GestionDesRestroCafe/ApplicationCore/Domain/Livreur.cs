using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Livreur
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }

        public Status Status { get; set; }

        // Many to one Commande
        public ICollection<Commande> Commandes { get; set; } = new List<Commande>();
    }

    public enum Status
    {
        Libre = 0,
        EnRoute = 1
    }
}
