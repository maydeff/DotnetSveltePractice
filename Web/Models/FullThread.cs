namespace Web.Models
{
    public class FullThread
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public DateTimeOffset Created { get; set; }
        public required string Content { get; set; }
    }
}
