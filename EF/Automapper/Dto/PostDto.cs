namespace EF.Automapper.Dto
{
    public class PostDto
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        //public BlogDto Blog { get; set; }
    }
}
