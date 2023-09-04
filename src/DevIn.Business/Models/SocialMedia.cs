namespace DevIn.Business.Models
{
    public class SocialMedia : Entity
    {
        public string Link { get; set; }
        public SocialMediaType SocialMediaType { get; set; }
    }
}
