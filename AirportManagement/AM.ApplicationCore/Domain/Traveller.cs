using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Traveller : Passenger
    {
        private string healthInformation { get; set; }
        private string nationality { get; set; }

        public override string ToString()
        {
            return "healthInformation: \n"
                + healthInformation
                + " nationality: \n"
                + nationality
                ;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a traveller");
        }
    }
}
