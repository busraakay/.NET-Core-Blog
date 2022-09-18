using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogByID(int id);
        List<Blog> GetBlogListWithWriter(int id);
        List<Blog> GetBlogListWithWriter();
        List<Blog> GetListWithCategoryByWriterBm(int id);
        public List<Blog> GetBlogWithWriterBm(int id);
    }
}
