using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.GenericAbstract
{
  public interface IGenericRepository< T> where T : class
    {
        public void Add(T entity);
        public void Delete(T entity);
        public int Commit();
        T Get(Func<bool, T>? func = null);
        List<T> GetAll(Func<bool, T>? func = null);
    }
}
