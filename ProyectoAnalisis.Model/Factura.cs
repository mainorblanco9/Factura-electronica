using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Model
{
    public class Factura
    {
        public int Id { get; set; }
        [Display(Name = "Fecha de Emision")]
        public DateTime FechaDeEmision { get; set; }
        [Display(Name = "Identificador de linea de detalle")]
        public int IdLinea { get; set; }
    }
}
