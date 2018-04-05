using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FanSoftStore.UI.Models
{
    [Table(nameof(TipoProduto))]
    public class TipoProduto : Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }
}
