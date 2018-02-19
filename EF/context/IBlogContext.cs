using EF.models;
using System.Collections.Generic;

namespace EF.context
{
    public interface IBlogContext
    {
        void Addnew();
        List<Blog> GetAll();
    }
}
