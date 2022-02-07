using System;
using System.Collections.Generic;

namespace SkolaLabb.Models
{
    public partial class Klass
    {
        public Klass()
        {
            Elev = new HashSet<Elev>();
        }

        public int KlassId { get; set; }
        public string KlassNamn { get; set; }

        public virtual ICollection<Elev> Elev { get; set; }
    }
}
