using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
    public class Starship
    {
        [Required]
        [StringLength(5,
            ErrorMessage = "Identificador muy largo (máximo 5 letras)")]
        [Display(Name = "Identificador de la Nave")]
        public string Identifier { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Classification { get; set; }

        [Range(1, 100,
            ErrorMessage = "Capacidad entre (1-100).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
            ErrorMessage = "This form disallows unapproved ships.")]
        public bool IsValidatedDesign { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }
    }
}
