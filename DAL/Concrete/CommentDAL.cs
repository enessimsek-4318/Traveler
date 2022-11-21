using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveler.Entity;

namespace DAL.Concrete
{
    public class CommentDAL: GenericRepository<Comment,DataContext>,ICommentDAL
    {
    }
}
