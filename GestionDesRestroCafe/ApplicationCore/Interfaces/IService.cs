using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IService
    {
        public IList<Livreur> GetLivreurs(IList<Livreur> livreurs);
        public double getPrixCommande(string numCmd);

        public double getBenefits(string dateCmd,IList<Livreur> livreurs);
    }
}
