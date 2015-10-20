namespace RheniumLeague.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seasone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seasone()
        {
            Rounds = new HashSet<Round>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Round> Rounds { get; set; }
    }
}
