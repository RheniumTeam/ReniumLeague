namespace MSSqul.Data
{
    using RheniumLeague.Models;
    using System.Data.Entity;

    public partial class RhenumLeague : DbContext
    {
        public RhenumLeague()
            : base("name=RheniumLeague")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchesStadium> MatchesStadiums { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<Seasone> Seasones { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                .Property(e => e.HomeTeamGoals)
                .IsFixedLength();

            modelBuilder.Entity<Match>()
                .Property(e => e.GuestTeamGoals)
                .IsFixedLength();

            modelBuilder.Entity<Match>()
                .HasMany(e => e.MatchesStadiums)
                .WithRequired(e => e.Match)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Round>()
                .HasMany(e => e.Matches)
                .WithRequired(e => e.Round)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seasone>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Seasone>()
                .HasMany(e => e.Rounds)
                .WithRequired(e => e.Seasone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Stadium>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Stadium>()
                .HasMany(e => e.MatchesStadiums)
                .WithRequired(e => e.Stadium)
                .HasForeignKey(e => e.MatchID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Matches)
                .WithRequired(e => e.Team)
                .HasForeignKey(e => e.HomeTeamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Matches1)
                .WithRequired(e => e.Team1)
                .HasForeignKey(e => e.GuestTeamID)
                .WillCascadeOnDelete(false);
        }
    }
}
