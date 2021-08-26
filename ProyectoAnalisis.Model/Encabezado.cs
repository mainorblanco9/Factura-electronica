using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
   public class Encabezado
    {
        public int Id { get; set; }
        [Display(Name = "Codigo de actividad")]
        public string CodigoDeActividad { get; set; }
        public string Clave { get; set; }
        public int NumeroConsecutivo { get; set; }

        public DateTime FechaDeEmision { get; set; }
        public int IdEmisor { get; set; }
        public int IdReceptor { get; set; }
        [Display(Name = "Condicion De Venta")]
        public CondicionDeVenta CondicionDeVenta { get; set; }
        [Display(Name = "Metodo Pago")]
        public IdMetodoPago IdMetodoPago { get; set; }
    }
}
