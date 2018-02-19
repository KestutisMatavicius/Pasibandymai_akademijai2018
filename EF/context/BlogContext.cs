using EF.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EF.context
{
    public class BlogContext : IBlogContext
    {
        protected readonly NrdAkademijaDbContext _rt;
        public BlogContext(NrdAkademijaDbContext rt)
        {
            _rt = rt;

        }
        public void Addnew()
        {

            _rt.Blog.Add(new models.Blog() { Url = "dgdg" });
            _rt.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            var lit = _rt.Blog.Include(c => c.Post).ToList();
            return lit.ToList();
        }
    }
}
