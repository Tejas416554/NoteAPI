namespace NotesAPI.Models
{
    public class Note
    {
        public int Id { get; set; }  // Primary Key
        public string Title { get; set; }  // Note Title
        public string Content { get; set; }  // Note Content
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Auto-set timestamp
        public DateTime LastUpdated { get; set; }

    }
}
