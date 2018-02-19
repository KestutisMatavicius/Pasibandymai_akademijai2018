using EF.models;
using System.Collections.Generic;

namespace EF.repository
{
    public interface IBlogRepository
    {
        void Addnew();
        List<Blog> GetAll();
    }
}
