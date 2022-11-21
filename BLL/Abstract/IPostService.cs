using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace BLL.Abstract
{
    public interface IPostService
    {
        Post GetById(int id);
        Post Find(Expression<Func<Post, bool>> filter);
        List<Post> GetAll(Expression<Func<Post, bool>> filter = null);
        void Create(Post entity);
        void Update(Post entity);
        void Delete(Post entity);
    }
}
