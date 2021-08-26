using ProyectoAnalisis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
   public class OperacionesDeFactura
    {
        public void AgregarUnProducto(Model.LineaDeDetalle lineaDeDetalle)
        {
          
            var db = new Context();
            db.LineaDeDetalle.Add(lineaDeDetalle);
            db.Entry(lineaDeDetalle).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public List<Model.LineaDeDetalle> ListarProductos()
        {
            var db = new Context();
            var resultado = from c in db.LineaDeDetalle
                            select c;
            return resultado.ToList();
        }
        public List<Model.Factura> ListarFactura()
        {
            var db = new Context();
            var resultado = from c in db.Factura
                            select c;
            return resultado.ToList();
        }
        public void AgregarEmisor(Model.FacturaElectronica facturaElectronica)
        {
            Model.Identificacion identificacion = new Model.Identificacion();
            Model.Ubicacion Ubicacion = new Model.Ubicacion();
            Model.Telefono Telefono = new Model.Telefono();
            Model.Emisor emisor = new Emisor();
            Telefono = facturaElectronica.Telefono1; Ubicacion = facturaElectronica.Ubicacion1; identificacion = facturaElectronica.Identificacion1;
            var db = new Context();
            db.Identificacion.Add(identificacion);
            db.Entry(identificacion).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            db.Ubicacion.Add(Ubicacion);
            db.Entry(Ubicacion).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            db.Telefono.Add(Telefono);
            db.Entry(Telefono).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            facturaElectronica.Emisor.Identificacion= Consultaridentificacion().Id;
            facturaElectronica.Emisor.Telefono = Consultartelefono().Id;
            facturaElectronica.Emisor.Ubicacion = ConsultarUbicacion().Id;
            emisor = facturaElectronica.Emisor;
            db.Emisor.Add(emisor);
            db.Entry(emisor).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public void AgregarReceptor(Model.FacturaElectronica facturaElectronica)
        {
            Model.Identificacion identificacion = new Model.Identificacion();
            Model.Ubicacion Ubicacion = new Model.Ubicacion();
            Model.Telefono Telefono = new Model.Telefono();
            Telefono = facturaElectronica.Telefono2; Ubicacion = facturaElectronica.Ubicacion2; identificacion = facturaElectronica.Identificacion2;
            var db = new Context();
            db.Identificacion.Add(identificacion);
            db.Entry(identificacion).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            db.Ubicacion.Add(Ubicacion);
            db.Entry(Ubicacion).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            db.Telefono.Add(Telefono);
            db.Entry(Telefono).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            facturaElectronica.Receptor.Identificacion = Consultaridentificacion().Id;
            facturaElectronica.Receptor.Telefono = Consultartelefono().Id;
            facturaElectronica.Receptor.Ubicacion = ConsultarUbicacion().Id;
            db.Receptor.Add(facturaElectronica.Receptor);
            db.Entry(facturaElectronica.Receptor).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        public void AgregarEncabezado(Model.Encabezado encabezado)
        {
            var db = new Context();

            db.Encabezado.Add(encabezado);
            db.Entry(encabezado).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public void AgregarUnaFactura(Model.Factura factura)
        {
            var db = new Context();
            
            db.Factura.Add(factura);
            db.Entry(factura).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public void AgregarFactura(Model.FacturaElectronica facturaElectronica)
        {
            Model.Factura factura = new Factura();

            AgregarEmisor(facturaElectronica);
            facturaElectronica.Encabezado.IdEmisor = facturaElectronica.Emisor.Id;
            facturaElectronica.Encabezado.IdReceptor = facturaElectronica.Receptor.Id;
            facturaElectronica.Encabezado.FechaDeEmision = DateTime.Today;
            AgregarReceptor(facturaElectronica);
            AgregarEncabezado(facturaElectronica.Encabezado);
            AgregarUnProducto(facturaElectronica.LineaDeDetalle);
            factura.FechaDeEmision = facturaElectronica.Encabezado.FechaDeEmision;
            factura.IdLinea = facturaElectronica.LineaDeDetalle.Id;
            AgregarUnaFactura(factura);
        }
        public Model.LineaDeDetalle ConsultarLinea(int Id)
        {

            var db = new Context();
            var resultado = (db.LineaDeDetalle.Find(Id));
            return resultado;
        }
        public Model.LineaDeDetalle Consultar()
        {

            var db = new Context();
            var listar = from c in db.LineaDeDetalle
                         select c;
            Model.LineaDeDetalle lineaDeDetalle = new Model.LineaDeDetalle();
            List<Model.LineaDeDetalle> LineaDeDetallelist = new List<LineaDeDetalle>();
            LineaDeDetallelist = listar.ToList();

            if (LineaDeDetallelist==null) {
                lineaDeDetalle.Id = 1;
        }
            else
            {
                lineaDeDetalle = LineaDeDetallelist.Last();
            }
            return lineaDeDetalle;
        }
        public Model.Telefono Consultartelefono()
        {

            var db = new Context();
            var listar = from c in db.Telefono
                         select c;
            Model.Telefono Telefono = new Model.Telefono();
            List<Model.Telefono> Telefonolist = new List<Telefono>();
            Telefonolist = listar.ToList();

            if (Telefonolist == null)
            {
                Telefono.Id = 1;
            }
            else
            {
                Telefono = Telefonolist.Last();
            }
            return Telefono;
        }
        public Model.Identificacion Consultaridentificacion()
        {

            var db = new Context();
            var listar = from c in db.Identificacion
                         select c;
            Model.Identificacion lineaDeDetalle = new Model.Identificacion();
            List<Model.Identificacion> LineaDeDetallelist = new List<Identificacion>();
            LineaDeDetallelist = listar.ToList();

            if (LineaDeDetallelist == null)
            {
                lineaDeDetalle.Id = 1;
            }
            else
            {
                lineaDeDetalle = LineaDeDetallelist.Last();
            }
            return lineaDeDetalle;
        }
        public Model.Ubicacion ConsultarUbicacion()
        {

            var db = new Context();
            var listar = from c in db.Ubicacion
                         select c;
            Model.Ubicacion lineaDeDetalle = new Model.Ubicacion();
            List<Model.Ubicacion> LineaDeDetallelist = new List<Ubicacion>();
            LineaDeDetallelist = listar.ToList();

            if (LineaDeDetallelist == null)
            {
                lineaDeDetalle.Id = 1;
            }
            else
            {
                lineaDeDetalle = LineaDeDetallelist.Last();
            }
            return lineaDeDetalle;
        }
        public decimal SumatoriaMontoTotal()
        {
            decimal sumatoria = 0;
            List<decimal> resultado = new List<decimal>();
            List<Factura> temp = new List<Factura>();
            temp = ListarFactura();

            foreach (var item in temp)
            {
                
                if (item.FechaDeEmision.CompareTo(DateTime.Today.Date)==0)
                {
                   sumatoria+= ConsultarLinea(item.IdLinea).MontoTotalLinea;
                }

            }

            return sumatoria;

        }

    }
}
