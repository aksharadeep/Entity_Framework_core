using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Exception
{
    //class to handel NoteNotFoundException
    class NoteNotFoundException :ApplicationException
    {
        public NoteNotFoundException() { }
        public NoteNotFoundException(string message) : base(message) { }
      
    }
}
