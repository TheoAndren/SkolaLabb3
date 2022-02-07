using System;
using System.Collections.Generic;

namespace SkolaLabb.Models
{
    public partial class Befattning
    {
        public Befattning()
        {
            Personal = new HashSet<Personal>();
        }

        public int BefattningsId { get; set; }
        public string BefattningsNamn { get; set; }

        public virtual ICollection<Personal> Personal { get; set; }
    }
}
