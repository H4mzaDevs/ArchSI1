using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AM.ApplicationCore.Domain.Plane;

namespace AM.ApplicationCore.Domain
{
    internal class Staff : Passenger
    {
        private DateOnly employmentDate { get; set; }
        private string function { get; set; }
        private float salary { get; set; }

        public override string ToString()
        {
            return "employmentDate: \n"
                + employmentDate.ToString()
                + " function: \n"
                + function
                + "salary : \n"
                + salary
                ;
        }

        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("and I'm a staff member");
        }

    }
}
