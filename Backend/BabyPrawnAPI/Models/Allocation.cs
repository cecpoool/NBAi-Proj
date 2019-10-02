using System;
using System.Collections.Generic;

namespace BabyPrawnAPI.Models
{
    public partial class Allocation
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }
    }
}
