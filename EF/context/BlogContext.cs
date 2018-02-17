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


    }
}
