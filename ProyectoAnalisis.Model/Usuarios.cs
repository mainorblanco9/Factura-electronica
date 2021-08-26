using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

  namespace ProyectoAnalisis.Model
{
    public class Usuarios
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Número de identificación ")]
        public String Cedula { get; set; }
        [Required]
        [Display(Name = "Primer nombre ")]
        public string Nombre1 { get; set; }
        [Required]
        [Display(Name = "Segundo nombre ")]
        public string Nombre2 { get; set; }
        [Required]
        [Display(Name = "Primer apellido ")]
        public string Apellido1 { get; set; }
        [Required]
        [Display(Name = "Segundo apellido ")]
        public string Apellido2 { get; set; }
       
        [Required]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
        [Required]
        public Puesto Puesto{ get; set; }
    }
}
