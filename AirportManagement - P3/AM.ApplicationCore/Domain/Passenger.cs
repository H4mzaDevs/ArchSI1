using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateOnly birthDate { get; set; }
        public int passportId { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long telNumber { get; set; }

        ICollection<Flight> flights;

        public override string ToString()
        {
            return "birthDate: \n"
                + birthDate
                + " passportId: \n"
                + passportId
                + "emailAddress : \n"
                + emailAddress
                + "firstName: \n"
                + firstName 
                + "lastName: \n"
                + lastName 
                + "telNumber: \n"
                + telNumber
                ;
        }

        public bool CheckProfile(string fn, string ln)
        {
            return firstName == fn && lastName == ln;
        }

        public bool CheckProfile(string fn, string ln, string email)
        {
            return firstName == fn && lastName == ln && emailAddress == email;
        }

        /* public bool CheckProfile(string fn, string ln, string email = null)
         {
             if (email != null)
                 return firstName == fn && lastName == ln &&
                 emailAddress == email;
             else
                 return firstName == fn && lastName == ln;
         } ERROR SAME NAME */

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }

   
    }
}
