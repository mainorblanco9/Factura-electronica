using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
    public class Telefono
    {
        public int Id { get; set; }
        [Display(Name = "Codigo del pais")]
        public string CodigoPais { get; set; }
        [Display(Name = "Numero de telefono")]
        public int NumeroTelefono { get; set; }

    }
}
