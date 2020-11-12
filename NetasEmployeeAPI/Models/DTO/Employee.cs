using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.DTO
{
    public  class Employee :IEmployee
    {
       
        public Employee()
        {
        }
        public string TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public double Salary { get; set; }


        public double Payment
        {

            get
            {

                return CalculatePayment();
            }

            set
            {
                CalculatePayment();
            }

        }

        public virtual double CalculatePayment() {
         
            return Salary;
        }
    }
}
