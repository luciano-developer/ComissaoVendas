namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VND001_VENDEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VND001_VENDEDOR()
        {
            VND002_VENDA = new HashSet<VND002_VENDA>();
        }

        [Key]
        public int IdeVendedor { get; set; }

        [Required]
        [StringLength(50)]
        public string NmeVendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VND002_VENDA> VND002_VENDA { get; set; }
    }
}
