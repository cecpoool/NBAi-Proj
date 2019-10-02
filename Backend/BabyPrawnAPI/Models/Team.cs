using System;
using System.Collections.Generic;

namespace BabyPrawnAPI.Models
{
    public partial class Team
    {
        public Team()
        {
            Allocation = new HashSet<Allocation>();
        }

        public int TeamId { get; set; }
        public string FullTeamName { get; set; }

        public virtual ICollection<Allocation> Allocation { get; set; }
    }
}
