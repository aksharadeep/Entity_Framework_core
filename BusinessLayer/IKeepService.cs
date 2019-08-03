using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
  public  interface IKeepService
    {
        Note GetNoteById(int id);
        List<Note> GetNotes();
        int AddNote(Note note);
        int UpdateNote(Note note);
        int DeleteNote(int id);
    }
}
