using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDFCore.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor maximo é 100")]
        [MinLength(2, ErrorMessage = "O valor minimo é 2")]
        public string Nome { get; set; }

        [Range(10, 1000, ErrorMessage = "Valor permitido entre 10 - 1000")]
        [Required(ErrorMessage = "o Valor é obrigatório")]
        public decimal Valor { get; set; }

        public bool Gratuito { get; set; }

        [Required(ErrorMessage = "O Descricao é obrigatorio")]
        [MaxLength(200, ErrorMessage = "O valor maximo é 200")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; } = DateTime.Now;

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
