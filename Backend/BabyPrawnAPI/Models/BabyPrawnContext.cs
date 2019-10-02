using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BabyPrawnAPI.Models
{
    public partial class BabyPrawnContext : DbContext
    {
        public BabyPrawnContext()
        {
        }

        public BabyPrawnContext(DbContextOptions<BabyPrawnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allocation> Allocation { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayersId> PlayersId { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:babyprawn.database.windows.net,1433;Initial Catalog=BabyPrawn;Persist Security Info=False;User ID=babyprawnadmin;Password=Babyprawn01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Allocation>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.PlayerId });

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Allocation)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Allocatio__Playe__6754599E");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Allocation)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Allocatio__TeamI__66603565");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.PlayerId).ValueGeneratedNever();

                entity.Property(e => e.Ast)
                    .HasColumnName("AST")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ast1)
                    .HasColumnName("AST%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Blk)
                    .HasColumnName("BLK")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Blk1)
                    .HasColumnName("BLK%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Bpm)
                    .HasColumnName("BPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Dbpm)
                    .HasColumnName("DBPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Drb)
                    .HasColumnName("DRB")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Drb1)
                    .HasColumnName("DRB%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Dws)
                    .HasColumnName("DWS")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.EFg)
                    .HasColumnName("eFG%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Fg)
                    .HasColumnName("FG")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Fg1)
                    .HasColumnName("FG%")
                    .HasColumnType("numeric(10, 9)");

                entity.Property(e => e.Fga)
                    .HasColumnName("FGA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ft)
                    .HasColumnName("FT")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ft1)
                    .HasColumnName("FT%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Fta)
                    .HasColumnName("FTA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ftr)
                    .HasColumnName("FTr")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Obpm)
                    .HasColumnName("OBPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Orb)
                    .HasColumnName("ORB")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Orb1)
                    .HasColumnName("ORB%")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Ows)
                    .HasColumnName("OWS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Per)
                    .HasColumnName("PER")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Pos)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pts)
                    .HasColumnName("PTS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Stl)
                    .HasColumnName("STL")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Stl1)
                    .HasColumnName("STL%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Tov)
                    .HasColumnName("TOV")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Tov1)
                    .HasColumnName("TOV%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Trb)
                    .HasColumnName("TRB")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Trb1)
                    .HasColumnName("TRB%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Usg)
                    .HasColumnName("USG%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Vorp)
                    .HasColumnName("VORP")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Ws)
                    .HasColumnName("WS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ws48)
                    .HasColumnName("WS_48")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._2p)
                    .HasColumnName("2P")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._2p1)
                    .HasColumnName("2P%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._2pa)
                    .HasColumnName("2PA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._3p)
                    .HasColumnName("3P")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e._3p1)
                    .HasColumnName("3P%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._3pa)
                    .HasColumnName("3PA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._3par)
                    .HasColumnName("3PAr%")
                    .HasColumnType("numeric(4, 3)");
            });

            modelBuilder.Entity<PlayersId>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK__PlayersI__4A4E74A811AB825C");

                entity.ToTable("PlayersID");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ast)
                    .HasColumnName("AST")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ast1)
                    .HasColumnName("AST%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Blk)
                    .HasColumnName("BLK")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Blk1)
                    .HasColumnName("BLK%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Bpm)
                    .HasColumnName("BPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Dbpm)
                    .HasColumnName("DBPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Drb)
                    .HasColumnName("DRB")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Drb1)
                    .HasColumnName("DRB%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Dws)
                    .HasColumnName("DWS")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.EFg)
                    .HasColumnName("eFG%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Fg)
                    .HasColumnName("FG")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Fg1)
                    .HasColumnName("FG%")
                    .HasColumnType("numeric(10, 9)");

                entity.Property(e => e.Fga)
                    .HasColumnName("FGA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ft)
                    .HasColumnName("FT")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ft1)
                    .HasColumnName("FT%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Fta)
                    .HasColumnName("FTA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ftr)
                    .HasColumnName("FTr")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Obpm)
                    .HasColumnName("OBPM")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Orb)
                    .HasColumnName("ORB")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Orb1)
                    .HasColumnName("ORB%")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Ows)
                    .HasColumnName("OWS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Per)
                    .HasColumnName("PER")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Pf)
                    .HasColumnName("PF")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Player)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Pos)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Pts)
                    .HasColumnName("PTS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Stl)
                    .HasColumnName("STL")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Stl1)
                    .HasColumnName("STL%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Tov)
                    .HasColumnName("TOV")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Tov1)
                    .HasColumnName("TOV%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Trb)
                    .HasColumnName("TRB")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Trb1)
                    .HasColumnName("TRB%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e.Usg)
                    .HasColumnName("USG%")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Vorp)
                    .HasColumnName("VORP")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e.Ws)
                    .HasColumnName("WS")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e.Ws48)
                    .HasColumnName("WS_48")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._2p)
                    .HasColumnName("2P")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._2p1)
                    .HasColumnName("2P%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._2pa)
                    .HasColumnName("2PA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._3p)
                    .HasColumnName("3P")
                    .HasColumnType("numeric(2, 1)");

                entity.Property(e => e._3p1)
                    .HasColumnName("3P%")
                    .HasColumnType("numeric(4, 3)");

                entity.Property(e => e._3pa)
                    .HasColumnName("3PA")
                    .HasColumnType("numeric(3, 1)");

                entity.Property(e => e._3par)
                    .HasColumnName("3PAr%")
                    .HasColumnType("numeric(4, 3)");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.TeamId).ValueGeneratedOnAdd().UseSqlServerIdentityColumn();

                entity.Property(e => e.FullTeamName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.Property(e => e.TeamsId).ValueGeneratedOnAdd().UseSqlServerIdentityColumn();

                entity.Property(e => e.FullTeamName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
