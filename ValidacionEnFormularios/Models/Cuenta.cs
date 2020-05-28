using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidacionEnFormularios.Models
{
    public class Cuenta
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string NombreUsuario { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        [MinLength(8)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Contraseña { get; set; }
        [Required]
        [Range(18, 50)]
        public int Edad { get; set; } //No es correcto, pero sirve para el ejemplo
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string SitioWeb { get; set; }
    }
}