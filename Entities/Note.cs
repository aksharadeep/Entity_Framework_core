using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Note
    {
      //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [JsonIgnore]
        public virtual ICollection<Label> labels { get; set; }
    }
}
