using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Exception
{
    //class to handel NoteAlreadyExistsException
    class NoteAlreadyExistsException :ApplicationException
    {
        public NoteAlreadyExistsException()
        { }
        public NoteAlreadyExistsException(string message) : base(message) {  }
    }
}
