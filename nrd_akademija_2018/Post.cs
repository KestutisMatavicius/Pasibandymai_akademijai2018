﻿namespace nrd_akademija_2018
{
    public partial class Postd
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public Blogd Blog { get; set; }
    }
}
