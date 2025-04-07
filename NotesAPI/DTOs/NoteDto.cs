// DTOs/NoteDto.cs
namespace NotesAPI.DTOs;

public class NoteDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime LastUpdated { get; set; }

}
