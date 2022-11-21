using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace BLL.Concrete
{
    public class PostManager : IPostService
    {
        public void Create(Post entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Find(Expression<Func<Post, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
