using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Include(x => x.Writer).ToList();
            }

        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x => x.WriterID == id).ToList();
            }
        }

        public List<Blog> GetListWithWriter()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Writer).ToList();
            }
        }

        public List<Blog> GetBlogWithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Include(x => x.Writer).Where(x => x.BlogID == id).ToList();
            }
        }
    }
}
