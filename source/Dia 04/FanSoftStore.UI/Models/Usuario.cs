using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FanSoftStore.UI.Models
{
    [Table("Usuario")]
    public class Usuario:Entity
    {
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Campo é obrigatório")]
        public string Senha { get; set; }
    }
}
