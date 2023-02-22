using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class PassengerExtension
{
    public static void UpperFullName(this Passenger p)
    {
        p.firstName = p.firstName[0].ToString().ToUpper() + p.firstName.Substring(1);
        p.lastName = p.lastName[0].ToString().ToUpper() + p.lastName.Substring(1);
    }
}
