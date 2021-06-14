using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComissaoVenda.Models
{
    public class RELATORIO
    {
        [Key]
        public int IdeVendedor { get; set; }

        [DisplayName("Nome do vendedor")]
        public string NmeVendedor { get; set; }

        [DisplayName("Quantidade de veículos vendidos")]
        public int QtdVendas { get; set; }

        [DisplayName("Quantidade de vales combutíveis emitidos")]
        public int QtdValeCombustivel { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Total em vendas")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal VlrTotalVendas { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Total da comissão")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal VlrTotalComissao { get; set; }

    }
}