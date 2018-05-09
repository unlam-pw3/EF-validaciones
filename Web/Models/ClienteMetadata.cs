using System.ComponentModel.DataAnnotations;
using System.Linq;

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
        [CustomValidation(typeof(ClienteMetadata), "ValidarEmailUnico")]
        public string Email { get; set; }

        public static ValidationResult ValidarEmailUnico(object value, ValidationContext context)
        {                 
            var cliente = context.ObjectInstance as Cliente;

            if (cliente == null || string.IsNullOrEmpty(cliente.Email))
                return new ValidationResult(string.Format("Email es requerido."));

            //para validar que no exista otro email igual, debo chequear en la base
            ClientesEntities db = new ClientesEntities();

            var existeEmail = db.Clientes.Any(o=> o.Email == cliente.Email);

            if (existeEmail)
            {
                return new ValidationResult(string.Format("El Email {0} ya está siendo usado.", cliente.Email));
            }

            return ValidationResult.Success;
        }

    }
}