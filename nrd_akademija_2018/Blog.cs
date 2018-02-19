using System.Collections.Generic;

namespace nrd_akademija_2018
{
    public partial class Blogd
    {
        public Blogd()
        {
            Post = new HashSet<Postd>();
        }

        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Postd> Post { get; set; }
    }
}
