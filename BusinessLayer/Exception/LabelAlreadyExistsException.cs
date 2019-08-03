using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Exception
{
    //class to handel LabelAlreadyExistsException
    class LabelAlreadyExistsException :ApplicationException
    {
        public LabelAlreadyExistsException()
        { }
        public LabelAlreadyExistsException(string message) : base(message) { }
    }
}

