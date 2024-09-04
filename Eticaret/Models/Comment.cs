namespace Eticaret.Models
{
    public class Comment
    {
        public int? CommentId { get; set; }
        public string? CommentUserName { get; set; }
        public string? Message { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
