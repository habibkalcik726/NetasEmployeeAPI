using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.DTO
{
    public class EmployeeType1 : Employee
    {

        public override double CalculatePayment()
        {
            return Salary;
        }
    }
}
