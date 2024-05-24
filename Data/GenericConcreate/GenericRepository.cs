using Core.GenericAbstract;
using Data.DAL;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.GenericConcreate
{
    public class GenericRepository
    {

        private readonly AppDbContext _db;

        public GenericRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
        }

        public T Get(Func<bool, T>? func = null)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Func<bool, T>? func = null)
        {
            throw new NotImplementedException();

        }
    }
}
