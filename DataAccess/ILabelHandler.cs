using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
  public  interface ILabelHandler
    {
        List<Label> GetLabels();
        Label GetLabelById(int id);
        int AddLabel(Label label);
        int UpdateLabel(Label label);
        int DeleteLabel(int id);
    }
}
