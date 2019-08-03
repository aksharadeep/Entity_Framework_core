using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class NoteDbContext : DbContext
    {
        public NoteDbContext() { }
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        //method to provide constraints and impose conditions
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasKey(n => new { n.NoteId });
            // modelBuilder.Entity<Note>().Property(n => n.NoteId).ValueGeneratedNever();
            modelBuilder.Entity<Label>().HasKey(l => new { l.LabelId });
            //modelBuilder.Entity<Label>().Property(l => l.LabelId).ValueGeneratedNever();
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Label> Labels { get; set; }
    }
}
