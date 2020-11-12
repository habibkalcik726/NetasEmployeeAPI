using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetasEmployeeAPI.Models.DBObjects.Context;
using NetasEmployeeAPI.Models.DTO;

namespace NetasEmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        protected DatabaseContext _dbContext { get; set; }
        public EmployeeController(DatabaseContext dbContext)
        {
            this._dbContext = dbContext;

        }

        /// <summary>
        /// Lists all the employess
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Employee> Get()
        {
            var result = _dbContext.Employees.ToList();
            List<Employee> reslist = new List<Employee>();
            Parallel.ForEach(_dbContext.Employees.ToList(), e =>
            {
                Employee type = new Employee();

                GetType(ref type, e.EmployeeTypeId);

                type.Name = e.Name;
                type.Surname = e.Surname;
                type.TC = e.TC;
                type.Salary = e.Salary;
                reslist.Add(type);
            });

            return reslist;
        }


        /// <summary>
        /// lists employe with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public Employee Get(int id)
        {
            var result = _dbContext.Employees.Find(id);// Where(x => x.ID == id).FirstOrDefault();
            if (result != null)
            {
                Employee type = new Employee();

                GetType(ref type, result.EmployeeTypeId);
                type.Name = result.Name;
                type.Surname = result.Surname;
                type.TC = result.TC;
                type.Salary = result.Salary;


                return type;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// gets type of employe 
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="empTypeId"></param>
        private void GetType(ref Employee emp, int empTypeId)
        {
            switch (empTypeId)
            {
                case 1:

                    emp = new EmployeeType1();
                    break;
                case 2:

                    emp = new EmployeeType2(15);//15 gün çalıştığı düşünülür
                    break;

                default:
                    emp = new EmployeeType3(30);//ekstra 30 saat çalıştığı farzedilir.
                    break;
            }

        }

    }
}