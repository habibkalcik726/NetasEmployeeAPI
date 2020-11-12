using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.Repository
{
    public interface IRepository<T>
    {


        List<T> List();
        int Save();

        int Insert(T obj);
        int Uptade(T obj);
        int Delete(T obj);

        T GetById(int Id);
    }
}
