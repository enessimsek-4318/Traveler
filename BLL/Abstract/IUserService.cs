using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace BLL.Abstract
{
    public interface IUserService
    {
        User GetById(int id);
        User Find(Expression<Func<User, bool>> filter);
        List<User> GetAll(Expression<Func<User, bool>> filter = null);
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
    }
}
