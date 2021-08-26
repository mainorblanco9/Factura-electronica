using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoAnalisis.Model
{
  public  class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        [Display(Name = "Precio Unitario")]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
    }
}
