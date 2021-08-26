using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Model
{
   public  class Cierres
    {
        public int Id { get; set; }
        [Display(Name = "Fecha de Emision")]
        public DateTime FechaDeEmision { get; set; }
        [Display(Name = "Monto Total")]
        public decimal MontoToTal { get; set; }
        [Display(Name = "Nombre del Usuario")]
        public string NombreDelUsuario { get; set; }
    }
}
