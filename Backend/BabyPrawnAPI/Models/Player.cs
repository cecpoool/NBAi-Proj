using System;
using System.Collections.Generic;

namespace BabyPrawnAPI.Models
{
    public partial class Player
    {
        public Player()
        {
            Allocation = new HashSet<Allocation>();
        }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string Pos { get; set; }
        public int? Age { get; set; }
        public decimal? Fg { get; set; }
        public decimal? Fga { get; set; }
        public decimal? Fg1 { get; set; }
        public decimal? _3p { get; set; }
        public decimal? _3pa { get; set; }
        public decimal? _3p1 { get; set; }
        public decimal? _2p { get; set; }
        public decimal? _2pa { get; set; }
        public decimal? _2p1 { get; set; }
        public decimal? EFg { get; set; }
        public decimal? Ft { get; set; }
        public decimal? Fta { get; set; }
        public decimal? Ft1 { get; set; }
        public decimal? Orb { get; set; }
        public decimal? Drb { get; set; }
        public decimal? Trb { get; set; }
        public decimal? Ast { get; set; }
        public decimal? Stl { get; set; }
        public decimal? Blk { get; set; }
        public decimal? Tov { get; set; }
        public decimal? Pf { get; set; }
        public decimal? Pts { get; set; }
        public decimal? Per { get; set; }
        public decimal? Ts { get; set; }
        public decimal? _3par { get; set; }
        public decimal? Ftr { get; set; }
        public decimal? Orb1 { get; set; }
        public decimal? Drb1 { get; set; }
        public decimal? Trb1 { get; set; }
        public decimal? Ast1 { get; set; }
        public decimal? Stl1 { get; set; }
        public decimal? Blk1 { get; set; }
        public decimal? Tov1 { get; set; }
        public decimal? Usg { get; set; }
        public decimal? Ows { get; set; }
        public decimal? Dws { get; set; }
        public decimal? Ws { get; set; }
        public decimal? Ws48 { get; set; }
        public decimal? Obpm { get; set; }
        public decimal? Dbpm { get; set; }
        public decimal? Bpm { get; set; }
        public decimal? Vorp { get; set; }

        public virtual ICollection<Allocation> Allocation { get; set; }
    }
}
