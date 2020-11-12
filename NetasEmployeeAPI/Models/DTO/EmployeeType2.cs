using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.DTO
{
    public class EmployeeType2 : Employee
    {

        private int _days { get; set; }
        public EmployeeType2(int days)
        {
            _days = days;
        }

        /// <summary>
        /// payment per day
        /// </summary>
        private double DailyPayment
        {
            get
            {
                return (Salary / 30);
            }
        }

        /// <summary>
        /// Calculates payment acdording to days at work
        /// </summary>
        /// <returns></returns>
        public override double CalculatePayment()
        {
            return _days * DailyPayment;
        }
    }
}
