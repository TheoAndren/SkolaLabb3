using System;
using System.Collections.Generic;

namespace SkolaLabb.Models
{
    public partial class Personal
    {
        public Personal()
        {
            Betyg = new HashSet<Betyg>();
        }

        public int AnställningsNr { get; set; }
        public string Fnamn { get; set; }
        public string Lnamn { get; set; }
        public string PrsNr { get; set; }
        public int BefattningsId { get; set; }

        public virtual Befattning Befattnings { get; set; }
        public virtual ICollection<Betyg> Betyg { get; set; }
    }
}
