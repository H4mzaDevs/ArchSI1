using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public DateOnly birthDate { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string healthInformation { get; set; }
        public string nationality { get; set; }


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

        public Traveller(String fn, String ln, String email, DateOnly birthdate, string hi,string nat)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.emailAddress = email;
            this.birthDate = birthdate;
            this.healthInformation = hi;
            this.nationality = nat;
        }
    }
}
