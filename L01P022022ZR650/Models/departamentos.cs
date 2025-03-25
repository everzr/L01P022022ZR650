using System.ComponentModel.DataAnnotations;

namespace L01P022022ZR650.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string? departamento { get; set; }
    }
}
