using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FanSoftStore.UI.Models
{
    [Table(nameof(Produto))]
    public class Produto:Entity
    {
        [Column(TypeName ="varchar(100)")]
        [Required]
        public string Nome { get; set; }

        public int TipoProdutoId { get; set; }

        [Column(TypeName ="money")]
        public decimal Valor { get; set; }

        [ForeignKey(nameof(TipoProdutoId))]
        public TipoProduto Tipo { get; set; }

    }
}
