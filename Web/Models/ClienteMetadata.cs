using System.ComponentModel.DataAnnotations;

namespace EF.Validaciones.Models
{
    public class ClienteMetadata
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Range(18, 99)]
        public int Edad { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}