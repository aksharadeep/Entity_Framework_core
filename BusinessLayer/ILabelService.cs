using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public interface ILabelService
    {
        Label GetLabelById(int id);
        List<Label> GetLabels();
        int AddLabel(Label label);
        int UpdateLabel(Label label);
        int DeleteLabel(int id);
    }
}
