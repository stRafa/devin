namespace DevIn.Business.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
