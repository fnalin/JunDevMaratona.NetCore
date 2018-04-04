using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FanSoftStore.UI.Models
{
    [Table(nameof(Produto))]
    public class Produto:Entity
    {
        [Column(TypeName ="varchar(100)")]
        [Required(ErrorMessage ="Campo é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório")]
        public int TipoProdutoId { get; set; }

        [Column(TypeName ="money")]
        [Required(ErrorMessage ="Campo é obrigatório")]
        public decimal Valor { get; set; }

        [ForeignKey(nameof(TipoProdutoId))]
        public TipoProduto Tipo { get; set; }

        [Column(TypeName ="varchar(300)")]
        [StringLength(300,ErrorMessage ="Limite de caracteres excedido")]
        public string Descricao { get; set; }

    }
}
