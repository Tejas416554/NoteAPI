using NotesAPI.Interfaces;
using NotesAPI.Models;
using AutoMapper;
using NotesAPI.DTOs;

namespace NotesAPI.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task<IEnumerable<Note>> GetAllNotesAsync()
        {
            return await _noteRepository.GetAllNotesAsync();
        }

        public async Task<Note> GetNoteByIdAsync(int id)
        {
            return await _noteRepository.GetNoteByIdAsync(id);
        }

        public async Task AddNoteAsync(Note note)
        {
            await _noteRepository.AddNoteAsync(note);
        }

        public async Task UpdateNoteAsync(Note note)
        {
            await _noteRepository.UpdateNoteAsync(note);
        }

        public async Task DeleteNoteAsync(int id)
        {
            await _noteRepository.DeleteNoteAsync(id);
        }
    }
}
