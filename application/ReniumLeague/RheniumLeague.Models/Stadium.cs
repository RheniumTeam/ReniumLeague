namespace RheniumLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stadiums")]
    public partial class Stadium
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stadium()
        {
            MatchesStadiums = new HashSet<MatchesStadium>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public int Capacity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchesStadium> MatchesStadiums { get; set; }
    }
}
