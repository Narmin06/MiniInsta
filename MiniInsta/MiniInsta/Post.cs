namespace MiniInsta;

internal class Post
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Text { get; set; }
    public string ImagePath { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public List<Tag> Tags { get; set; }
}
