namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VEI004_MODELO_VERSAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEI004_MODELO_VERSAO()
        {
            VND002_VENDA = new HashSet<VND002_VENDA>();
        }

        [Key]
        public int IdeModeloVersao { get; set; }

        public int IdeModelo { get; set; }

        public byte IdeCombustivel { get; set; }

        public short? NroAno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VlrPrecoTabelado { get; set; }

        public virtual VEI002_MODELO VEI002_MODELO { get; set; }

        public virtual VEI003_COMBUSTIVEL VEI003_COMBUSTIVEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VND002_VENDA> VND002_VENDA { get; set; }
    }
}
