namespace RheniumLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Match
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Match()
        {
            MatchesStadiums = new HashSet<MatchesStadium>();
        }

        public int id { get; set; }

        public int HomeTeamID { get; set; }

        public int GuestTeamID { get; set; }

        [Required]
        [StringLength(10)]
        public string HomeTeamGoals { get; set; }

        [Required]
        [StringLength(10)]
        public string GuestTeamGoals { get; set; }

        public int Attendnce { get; set; }

        public DateTime Date { get; set; }

        public int RoundID { get; set; }

        public int StadiumID { get; set; }

        public virtual Round Round { get; set; }

        public virtual Team Team { get; set; }

        public virtual Team Team1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchesStadium> MatchesStadiums { get; set; }
    }
}
