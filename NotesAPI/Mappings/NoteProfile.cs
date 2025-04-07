using AutoMapper;
using NotesAPI.Models;
using NotesAPI.DTOs;

namespace NotesAPI.Mappings;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<Note, NoteDto>();
        CreateMap<CreateNoteDto, Note>();
        CreateMap<UpdateNoteDto, Note>();
    }
}
