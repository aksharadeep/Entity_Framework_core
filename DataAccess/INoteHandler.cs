using Entities;
using System.Collections.Generic;

namespace DataAccess
{
   public interface INoteHandler
    {
        Note GetNoteById(int id);
        List<Note> GetNotes();
        int AddNote(Note note);
        int UpdateNote(Note note);
        int DeleteNote(int id);
    }
}
