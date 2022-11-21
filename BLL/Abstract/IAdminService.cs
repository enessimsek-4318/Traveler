using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace BLL.Abstract
{
    public interface IAdminService
    {
        Admin GetById(int id);
        Admin Find(Expression<Func<Admin, bool>> filter);
        List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null);
        void Create(Admin entity);
        void Update(Admin entity);
        void Delete(Admin entity);

    }
}
