using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brock_CourseProject_Part2
{
    public class Employee
    {
        // attributes
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits;

        // constructors
        //public Employee()
        //{
        //    firstName = "N/A";
        //    lastName = "N/A";
        //    ssn = "N/A";
        //    hireDate = new DateTime();
        //}

        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            BenefitsPackage = benefits;
        }

        // behaviors
        public override string ToString()
        {
            return "firstName=" + firstName
                + ", lastName=" + lastName
                + ", ssn=" + ssn
                + ", hireDate=" + hireDate.ToShortDateString()
                + ", benifits=" + benefits.ToString();

        }
        
        public double CalculatePay()
        {
            return 0.0;
        }

        // properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public Benefits BenefitsPackage
        {
            get
            {
                return benefits;
            }
            set
            {
                this.benefits = value;
            }
        }
    }
}
