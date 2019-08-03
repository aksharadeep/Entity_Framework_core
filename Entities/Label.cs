using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Label
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LabelId { get; set; }
        public string Description { get; set; }
        public int NoteId { get; set; }
        [JsonIgnore]
        public virtual Note note { get; set; }
    }
}