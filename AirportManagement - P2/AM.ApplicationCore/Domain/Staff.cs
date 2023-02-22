

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateOnly birthDate { get; set; }
        public string emailAddress { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
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

        public Staff(String fn , String ln , String email, DateOnly birthdate,DateOnly emp,float sal)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.emailAddress = email;
            this.birthDate = birthdate;
            this.employmentDate = emp;
            this.salary = sal;
        }
    }
}
