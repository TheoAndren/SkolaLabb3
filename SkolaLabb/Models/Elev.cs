using System;
using System.Collections.Generic;

namespace SkolaLabb.Models
{
    public partial class Elev
    {
        public Elev()
        {
            Betyg = new HashSet<Betyg>();
        }

        public int ElevId { get; set; }
        public string Fnamn { get; set; }
        public string Lnamn { get; set; }
        public string PrsNr { get; set; }
        public int KlassId { get; set; }

        public virtual Klass Klass { get; set; }
        public virtual ICollection<Betyg> Betyg { get; set; }
    }
}
