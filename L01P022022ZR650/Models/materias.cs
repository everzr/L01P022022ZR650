using System.ComponentModel.DataAnnotations;

namespace L01P022022ZR650.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string? materia { get; set; }

        [Required]
        public int unidades_valorativas { get; set; }

        [Required]
        [StringLength(1)]
        public string estado { get; set; }
    }
}
