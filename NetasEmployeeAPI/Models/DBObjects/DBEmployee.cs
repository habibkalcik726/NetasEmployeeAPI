using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.DBObjects
{
    public class DBEmployee
    {


        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }

        public int Payment { get; set; }

        [ForeignKey("EmployeeType")]
        public int EmployeeTypeId { get; set; }

        public virtual DBEmployeeType EmployeeType { get; set; }
    }
}
