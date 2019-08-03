using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Exception;
using DataAccess;
using Entities;

namespace BusinessLayer
{
    public class LabelService : ILabelService
    {
        private readonly ILabelHandler labelHandler;
        //getting the object of LabelService
        public LabelService(ILabelHandler handler)
        {
            labelHandler = handler;
        }
        //method to add a label and throw appropriate exception if any
        public int AddLabel(Label label)
        {
            var _label = labelHandler.GetLabelById(label.LabelId);
            if (_label == null)
            {
                return labelHandler.AddLabel(label);
            }
            else
            {
                throw new LabelAlreadyExistsException($"label with id {label.LabelId} already exists");
            }

        }
        //get label by id
        public Label GetLabelById(int id)
        {
            var label = labelHandler.GetLabelById(id);
            if (label == null)
            {
                throw new LabelNotFoundException($"label with id {id} not found");
            }
            else
            {
                return label;
            }

        }
        //gets a list of labels
        public List<Label> GetLabels()
        {
            return labelHandler.GetLabels();
        }
        //method to delete a label by id
        public int DeleteLabel(int id)
        {
            var label = labelHandler.GetLabelById(id);
            if (label == null)
            {
                throw new LabelNotFoundException($"label with id {id} not found");
            }
            else
            {
                return labelHandler.DeleteLabel(id);
            }

        }
        //method to update a label
        public int UpdateLabel(Label label)
        {
            var _label = labelHandler.GetLabelById(label.LabelId);
            if (_label == null)
            {
                throw new LabelNotFoundException($"label with id {label.LabelId} not found");
            }
            else
            {
                _label.Description = label.Description;
                return labelHandler.UpdateLabel(_label);
            }
        }
    }
}
