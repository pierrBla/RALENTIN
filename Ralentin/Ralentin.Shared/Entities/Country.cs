using System.ComponentModel.DataAnnotations;

namespace Ralentin.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El  Campo {0} es Requerido")]

        [MaxLength(100, ErrorMessage = "El Campo {0} no puede tener mas de {1} caracteres ")]
        public string Name { get; set; } = null!;
    }
}