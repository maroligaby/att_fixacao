using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PjGabriellyMaroli.Models
{
    public class Psicologo : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido")]
        [Display(Name= "Nome completo")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "CRP requerido")]
        [Display(Name = "CRP")]
        public int CRP { get; set; }

        [Required(ErrorMessage = "Endereço requerido")]
        [Display(Name = "Endereço")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Data requerida")]
        [Display(Name = "Data de nascimento")]
        public DateTime? Nascimento { get; set; }
    }

}
