using System.Collections.Generic;

namespace EF.Automapper.Dto
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public List<PostDto> Posts { get; set; }
    }
}
