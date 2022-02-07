using System;
using System.Collections.Generic;

namespace SkolaLabb.Models
{
    public partial class Betyg
    {
        public int BetygsId { get; set; }
        public string KursNamn { get; set; }
        public string Betyg1 { get; set; }
        public DateTime? BetygsDatum { get; set; }
        public int LärarId { get; set; }
        public int ElevId { get; set; }

        public virtual Elev Elev { get; set; }
        public virtual Personal Lärar { get; set; }
    }
}
