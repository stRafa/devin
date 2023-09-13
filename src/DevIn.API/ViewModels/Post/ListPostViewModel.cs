using DevIn.Business.Models;

namespace DevIn.API.ViewModels.Post
{
    public class ListPostViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
