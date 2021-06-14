namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEI001_MARCA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEI001_MARCA()
        {
            VEI002_MODELO = new HashSet<VEI002_MODELO>();
        }

        [Key]
        public int IdeMarca { get; set; }

        [Required]
        [StringLength(35)]
        public string NmeMarca { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEI002_MODELO> VEI002_MODELO { get; set; }
    }
}
