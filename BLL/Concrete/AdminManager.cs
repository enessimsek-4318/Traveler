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
    public class AdminManager : IAdminService
    {
        private IAdminDAL _adminDAL;
        public AdminManager(IAdminDAL adminDAL)
        {
            _adminDAL = adminDAL;
        }

        public void Create(Admin entity)
        {
            _adminDAL.Create(entity);
        }

        public void Delete(Admin entity)
        {
            _adminDAL.Delete(entity);
        }

        public Admin Find(Expression<Func<Admin, bool>> filter)
        {
            return _adminDAL.Find(filter);
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null)
        {
            return _adminDAL.GetAll(filter).ToList();
        }

        public Admin GetById(int id)
        {
            return _adminDAL.GetById(id);
        }

        public void Update(Admin entity)
        {
            _adminDAL.Update(entity);
        }
    }
}
