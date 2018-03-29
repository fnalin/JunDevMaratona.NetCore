using System;
using System.ComponentModel.DataAnnotations;

namespace FanSoftStore.UI.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
