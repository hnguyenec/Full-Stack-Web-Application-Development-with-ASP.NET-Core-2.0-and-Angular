using Macaria.Core.Common;
using System.Collections.Generic;

namespace Macaria.Core.Models
{
    public class Tag: Entity
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public ICollection<NoteTag> NoteTags { get; set; } = new HashSet<NoteTag>();
    }
}
