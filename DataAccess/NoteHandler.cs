using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace DataAccess
{
    public class NoteHandler : INoteHandler
    {
        private readonly NoteDbContext context;
        public NoteHandler(NoteDbContext noteDbContext)
        {
            context = noteDbContext;
        }
        //method to add a note into the table
        public int AddNote(Note note)
        {
            context.Notes.Add(note);
            return context.SaveChanges();
        }
        //method to get note by id
        public Note GetNoteById(int id)
        {
            return context.Notes.Find(id);
        }
        //method to get all notes
        public List<Note> GetNotes()
        {
            return context.Notes.ToList();
        }
        //method to update the note
        public int UpdateNote(Note note)
        {
            context.Entry<Note>(note).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }
        //method to delete note by id
        public int DeleteNote(int id)
        {
            var note = context.Notes.Find(id);
            context.Notes.Remove(note);
            return context.SaveChanges();
        }


    }
}
