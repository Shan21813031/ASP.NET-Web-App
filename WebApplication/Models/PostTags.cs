namespace WebApplication.Models
{
    public class PostTags
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public int TagsId { get; set; }

        public Post Post { get; set; }

        public Tags Tags { get; set; }
    }
}
