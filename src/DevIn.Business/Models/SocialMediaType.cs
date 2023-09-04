namespace DevIn.Business.Models
{
    public class SocialMediaType : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public IList<SocialMedia> SocialMedia { get; set; }
    }
}
