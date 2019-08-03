using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace DataAccess
{
    public class LabelHandler : ILabelHandler
    {
        private readonly NoteDbContext context;
        public LabelHandler(NoteDbContext noteDbContext)
        {
            context = noteDbContext;
        }
        //method to add a label into the table
        public int AddLabel(Label label)
        {
            context.Labels.Add(label);
            return context.SaveChanges();
        }
        //method to get all labels
        public List<Label> GetLabels()
        {
            return context.Labels.ToList();
        }
        //method to get label by id
        public Label GetLabelById(int id)
        {
            return context.Labels.Find(id);
        }
        //method to update the label
        public int UpdateLabel(Label label)
        {
            context.Entry<Label>(label).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }
        //method to delete a label by id
        public int DeleteLabel(int id)
        {
            var label = context.Labels.Find(id);
            context.Labels.Remove(label);
            return context.SaveChanges();
        }

    }
}
