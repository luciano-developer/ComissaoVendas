namespace ComissaoVenda.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VND002_VENDA
    {
        [Key]
        public int IdeVenda { get; set; }

        public int IdeVendedor { get; set; }

        public int IdeModeloVersao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VlrPrecoVenda { get; set; }

        public bool StaValeCombustivel { get; set; }

        public virtual VEI004_MODELO_VERSAO VEI004_MODELO_VERSAO { get; set; }

        public virtual VND001_VENDEDOR VND001_VENDEDOR { get; set; }
    }
}
