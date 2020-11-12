using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.DTO
{
    public class EmployeeType3 : Employee
    {

        private int _extraHours { get; set; }
        public EmployeeType3(int extraHours)
        {
            _extraHours = extraHours;
        }

        private double HourlyPayment
        {
            get
            {
                return (Salary / 30) / 9; //günde 9 saat çalıştığı farzedilir.
            }
        }
      

       
        /// <summary>
        /// Calculates payment acdording to extra hours and salary
        /// </summary>
        /// <returns></returns>
        public override double CalculatePayment()
        {
            return (HourlyPayment * _extraHours) + Salary;
        }
    }
}
