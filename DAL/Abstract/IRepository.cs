using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IRepository<T>
    {   
        public T GetById(int id);
        public T Find(int id);
        public List<T> GetAll(Expression<Func<T,bool>>filter=null);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
