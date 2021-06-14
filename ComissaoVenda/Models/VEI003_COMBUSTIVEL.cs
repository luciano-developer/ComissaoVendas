namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEI003_COMBUSTIVEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEI003_COMBUSTIVEL()
        {
            VEI004_MODELO_VERSAO = new HashSet<VEI004_MODELO_VERSAO>();
        }

        [Key]
        public byte IdeCombustivel { get; set; }

        [Required]
        [StringLength(15)]
        public string NmeCombustivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEI004_MODELO_VERSAO> VEI004_MODELO_VERSAO { get; set; }
    }
}
