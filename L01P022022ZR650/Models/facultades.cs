using System.ComponentModel.DataAnnotations;

namespace L01P022022ZR650.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string? facultad { get; set; }
    }
}
