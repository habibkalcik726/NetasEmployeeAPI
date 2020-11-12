using Microsoft.EntityFrameworkCore;
using NetasEmployeeAPI.Models.DBObjects.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetasEmployeeAPI.Models.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;


        protected DatabaseContext _dbContext { get; set; }
        public EFRepository(DatabaseContext repositoryContext)
        {
            this._dbContext = repositoryContext;
            _objectSet = _dbContext.Set<T>();
        }


        //private readonly DatabaseContext _dbContext;
        //public EFRepository(DatabaseContext context)
        //{
        //    this._dbContext = context;
        //    _objectSet = _dbContext.Set<T>();
        //}

        //public EFRepository()
        //{
        //    _objectSet = _dbContext.Set<T>();
        //}
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();

        }

        public T GetById(int Id)
        {
            return _objectSet.Find(Id);
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();

        }

        public int Uptade(T obj)
        {
            return Save();
        }
    }
}
