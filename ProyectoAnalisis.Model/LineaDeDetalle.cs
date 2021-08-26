using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
  public  class LineaDeDetalle
    {
        public int Id { get; set; }
        public int NumeroDeLinea { get; set; }
        [Required]
        public decimal Cantidad { get; set; }
        [Display(Name = "Unidad de medida ")]
        public string UnidadMedida { get; set; }
        public string Detalle { get; set; }
        [Required]
        [Display(Name = "Precio Unitario")]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        [Display(Name = "Monto total")]
        public decimal MontoTotal { get; set; }
        [Display(Name = "Monto total de linea ")]
        public decimal MontoTotalLinea { get; set; }

    }
}
