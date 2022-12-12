using BLL.Abstract;
using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace BLL.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDAL _userDal;

        public UserManager(IUserDAL userDal) 
        {
            _userDal = userDal;
        }

        public void Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Find(Expression<Func<User, bool>> filter)
        {
            return _userDal.Find(filter);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
