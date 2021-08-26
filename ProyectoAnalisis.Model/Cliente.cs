using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
  public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; }

        public TipoIdentificacion Tipo { get; set; }
        [Required]
        [Display(Name = "Número de identificación ")]
        public int Numero { get; set; }
        [Display(Name = "Nombre comercial")]
        public string NombreComercial { get; set; }
      
        [Display(Name = "Codigo de pais")]
        public int CodigoPais { get; set; }
        [Display(Name = "Numero de telefono")]
        public int NumeroTelefono { get; set; } 


        [Display(Name = "Correo")]
        public string Correo { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        [Display(Name = "Otras Señas ")]
        public string OtrasSeñas { get; set; }

    }
}
