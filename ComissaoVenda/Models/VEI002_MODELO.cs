namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEI002_MODELO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEI002_MODELO()
        {
            VEI004_MODELO_VERSAO = new HashSet<VEI004_MODELO_VERSAO>();
        }

        [Key]
        public int IdeModelo { get; set; }

        public int IdeMarca { get; set; }

        [Required]
        [StringLength(8)]
        public string CodModelo { get; set; }

        [Required]
        [StringLength(50)]
        public string NmeModelo { get; set; }

        public virtual VEI001_MARCA VEI001_MARCA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEI004_MODELO_VERSAO> VEI004_MODELO_VERSAO { get; set; }
    }
}
