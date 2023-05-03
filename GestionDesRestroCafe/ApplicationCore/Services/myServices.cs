using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationCore.Domain.Livreur;

namespace ApplicationCore.Services
{
    public interface myServices : IService
    {
        public IList<Livreur> GetLivreurs(IList<Livreur> livreurs)
        {
            IList<Livreur> list= new List<Livreur>();
            foreach ( var l in livreurs)
            {
                if (l.Status == Status.Libre) {
                    list.Add(l);
                }
            }
            return list;
        }

        public double getPrixCommande(string numCmd,IList<Commande> commandes)
        {
            double s = 0;
            foreach ( var c in commandes)
            {
                if (c.NumCmd.Contains(numCmd))
                {
                    foreach(var cpl in c.Plats)
                    {
                        s = s + cpl.Prix;
                    }
                }
            }
            return s;

        }

        public double getBenefits(string dateCmd, IList<Livreur> livreurs)
        {
            double b = 0;
            foreach ( var l in livreurs)
            {
                foreach ( var c in l.Commandes)
                {
                    if (c.DateCmd.ToString().Contains(dateCmd))
                    {
                        foreach (var cpl in c.Plats)
                        {
                            b = b + ((cpl.Prix * 5) / 100);
                        }
                    }
                }
            }
            return b;
        }
    }
}
