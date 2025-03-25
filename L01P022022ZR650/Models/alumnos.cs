using System.ComponentModel.DataAnnotations;

namespace L01P022022ZR650.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "ID")]
        public int id {  get; set; }
        
        [Required]
        [StringLength(10)]
        public string codigo { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string nombre { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string apellidos { get; set; } = null!;

        [Required]
        public int dui { get; set; }

        [Required]
        public int estado { get; set; }
    }
}
