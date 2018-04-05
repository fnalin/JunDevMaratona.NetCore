using System.ComponentModel.DataAnnotations;

namespace FanSoftStore.UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Campo é obrigatório")]
        [StringLength(100,ErrorMessage ="Tamanho excedido")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)",ErrorMessage ="Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório")]
        [StringLength(100, ErrorMessage = "Tamanho excedido")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool Lembrar { get; set; }

        public string ReturnUrl { get; set; }
    }
}
