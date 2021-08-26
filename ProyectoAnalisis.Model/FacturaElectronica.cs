using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Model
{
  public  class FacturaElectronica
    {
        public Encabezado Encabezado { get; set; }
        public Emisor Emisor { get; set; }
        public Receptor Receptor { get; set; }
        public LineaDeDetalle LineaDeDetalle { get; set; }

        public Ubicacion Ubicacion1 { get; set; }
        public Ubicacion Ubicacion2 { get; set; }
        public List<Provincia> provincia { get; set; }
        public List<Canton> canton { get; set; }
        public List<Distrito> distrito { get; set; }
        public Telefono Telefono1 { get; set; }
        public Telefono Telefono2 { get; set; }
        public Identificacion Identificacion1 { get; set; }
        public Identificacion Identificacion2 { get; set; }
        public ProductosFactura ProductosFactura { get; set; }
        public List<ProductosFactura> productosFacturas { get; set; }
        public List<ElementJsonIntKey> Receptores { get; set; }


    }
}
