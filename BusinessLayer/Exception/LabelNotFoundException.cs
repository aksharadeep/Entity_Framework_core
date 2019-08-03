using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Exception
{
    //class to handel LabelNotFoundException
    class LabelNotFoundException :ApplicationException
    {
        public LabelNotFoundException() { }
        public LabelNotFoundException(string message) : base(message) { }
    }
}
