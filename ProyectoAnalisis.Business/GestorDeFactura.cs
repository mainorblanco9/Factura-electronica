using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoAnalisis.Business
{
    public class GestorDeFactura
    {
        public void RegistrarunProductoDeFactura(Model.LineaDeDetalle lineaDeDetalle)
        {
            
            lineaDeDetalle.MontoTotal = CalcularMontototal(lineaDeDetalle);
            lineaDeDetalle.Subtotal = CalcularSubtotal(lineaDeDetalle);
            lineaDeDetalle.Impuesto = CalcularImpuesto(lineaDeDetalle);
            lineaDeDetalle.MontoTotalLinea = CalcularMontoLinea(lineaDeDetalle);
          
        }
        public decimal CalcularSubtotal(Model.LineaDeDetalle lineaDeDetalle)
        {
            decimal i=0 ,p=0, s=0;
            p = lineaDeDetalle.Descuento / 100;
            i = lineaDeDetalle.MontoTotal*p ;
            s = lineaDeDetalle.MontoTotal - i;
            return s;
        }
        public decimal CalcularMontototal(Model.LineaDeDetalle lineaDeDetalle)
        {
            decimal i = 0;
            i = lineaDeDetalle.Cantidad * lineaDeDetalle.PrecioUnitario;
            return i;
        }
        public decimal CalcularMontoLinea(Model.LineaDeDetalle lineaDeDetalle)
        {
            decimal i = 0;
            i = lineaDeDetalle.Subtotal + lineaDeDetalle.Impuesto;
            return i;
        }
        public decimal CalcularImpuesto(Model.LineaDeDetalle lineaDeDetalle)
        {
            decimal i = 0;

            i = (lineaDeDetalle.Subtotal * Convert.ToDecimal(0.13));
            return i;
        }
        public List<Model.LineaDeDetalle> ListarProductos()
        {
            List<Model.LineaDeDetalle> laLista = new List<Model.LineaDeDetalle>();
            DB.OperacionesDeFactura operaciones = new DB.OperacionesDeFactura();
            laLista = operaciones.ListarProductos();
            return laLista;
        }
        public List<Model.Factura> ListarFactura()
        {
            
            DB.OperacionesDeFactura operaciones = new DB.OperacionesDeFactura();
          var   laLista = operaciones.ListarFactura();
            return laLista;
        }
        public void RegistarUnaFactura(Model.FacturaElectronica facturaElectronica) {

            DB.OperacionesDeInventario EncontrarPrecioU = new DB.OperacionesDeInventario();
            facturaElectronica.LineaDeDetalle.PrecioUnitario = EncontrarPrecioU.Consultar(facturaElectronica.ProductosFactura.Id).PrecioUnitario;
            facturaElectronica.Emisor = RegistarElEmisor();
            facturaElectronica.Identificacion1 = RegistarIdentificacionEmisor();
            facturaElectronica.Ubicacion1 = RegistarLaUbicacionEmisor();
            facturaElectronica.Telefono1 = RegistarElTelefonoEmisor();
            facturaElectronica.Receptor = RegistarReceptor(facturaElectronica.Receptor.Id);
            facturaElectronica.Identificacion2 = RegistarIdentificacionReceptor(facturaElectronica.Receptor.Id);
            facturaElectronica.Ubicacion2 = RegistarUbicacionReceptor(facturaElectronica.Receptor.Id);
            facturaElectronica.Telefono2= RegistarTelefonoReceptor(facturaElectronica.Receptor.Id);
            DB.OperacionesDeFactura operacionesDeFactura = new DB.OperacionesDeFactura();
            RegistrarunProductoDeFactura(facturaElectronica.LineaDeDetalle);
            facturaElectronica.LineaDeDetalle.NumeroDeLinea = 1;
            operacionesDeFactura.AgregarFactura(facturaElectronica);
            GenerarXML(facturaElectronica);

        }
        public Model.Identificacion RegistarIdentificacionReceptor(int id)
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            Model.Identificacion Identificacion = new Model.Identificacion();
            Identificacion.Tipo = operacionesDeCliente.Consultar(id).Tipo;
            Identificacion.Numero = operacionesDeCliente.Consultar(id).Numero;
            return Identificacion;
        }
        public Model.Telefono RegistarTelefonoReceptor(int id)
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            Model.Telefono Telefono = new Model.Telefono();
            Telefono.CodigoPais = operacionesDeCliente.Consultar(id).CodigoPais.ToString();
            Telefono.NumeroTelefono = operacionesDeCliente.Consultar(id).NumeroTelefono;
            return Telefono;
        }
        public Model.Receptor RegistarReceptor(int id)
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            Model.Receptor receptor = new Model.Receptor();
            receptor.Nombre = operacionesDeCliente.Consultar(id).Nombre;
            receptor.NombreComercial = operacionesDeCliente.Consultar(id).NombreComercial;
            receptor.Correo= operacionesDeCliente.Consultar(id).Correo;
            receptor.Id = id;
            
            return receptor;
        }
        public Model.Ubicacion RegistarUbicacionReceptor(int id)
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            Model.Ubicacion ubicacion = new Model.Ubicacion();
            Model.Cliente c = new Model.Cliente();
            c = operacionesDeCliente.Consultar(id);
            ubicacion.Provincia = c.Provincia;
            
            ubicacion.Distrito = operacionesDeCliente.Consultar(id).Distrito;

            ubicacion.Canton= operacionesDeCliente.Consultar(id).Canton;

            ubicacion.OtrasSeñas = operacionesDeCliente.Consultar(id).OtrasSeñas;
            return ubicacion;
        }

        public Model.Identificacion RegistarIdentificacionEmisor()
        {
            Model.Identificacion Identificacion = new Model.Identificacion();
            Identificacion.Tipo = Model.TipoIdentificacion.Cedulafisica;
            Identificacion.Numero = 504240212;
            return Identificacion;
        }
        public Model.Telefono RegistarElTelefonoEmisor()
        {
            Model.Telefono Telefono = new Model.Telefono();
            Telefono.CodigoPais = "506";
            Telefono.NumeroTelefono = 26867923;
            return Telefono;        }
        public Model.Ubicacion RegistarLaUbicacionEmisor()
        {
            Model.Ubicacion Ubicacion = new Model.Ubicacion();
          
           Ubicacion.OtrasSeñas = "costado oeste del surtidor nancy";
            return Ubicacion;
        }
        public Model.Emisor RegistarElEmisor()
        {
            Model.Emisor emisor = new Model.Emisor();
           
            
            emisor.Nombre = "UCR Facturas";
            emisor.NombreComercial = "UCR Facturas";
            emisor.Correo = "Ucr@ucr.ac.cr";
           
            
            return emisor;
        }
        
        public void GenerarXML(Model.FacturaElectronica facturaElectronica)
        {
            XDocument xDocument = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement nodoRaiz = new XElement("FacturaElectroica");
            xDocument.Add(nodoRaiz);
            XElement Clave = new XElement("Clave", facturaElectronica.Encabezado.Clave);
            nodoRaiz.Add(Clave);
            XElement CodigoActividad = new XElement("CodigoActividad", facturaElectronica.Encabezado.CodigoDeActividad);
            nodoRaiz.Add(CodigoActividad);
            XElement NumeroConsecutivo = new XElement("NumeroConsecutivo", facturaElectronica.Encabezado.NumeroConsecutivo);
            nodoRaiz.Add(NumeroConsecutivo);
            XElement FechaEmision = new XElement("FechaEmision", facturaElectronica.Encabezado.FechaDeEmision);
            nodoRaiz.Add(FechaEmision);
            XElement Emisor = new XElement("Emisor");
            Emisor.Add(new XElement("Nombre", facturaElectronica.Emisor.Nombre));
            XElement Identificacion1 = new XElement("Identificacion");
            Identificacion1.Add(new XElement("Tipo", facturaElectronica.Identificacion1.Tipo));
            Identificacion1.Add(new XElement("Numero", facturaElectronica.Identificacion1.Numero));
            Emisor.Add(Identificacion1);
            Emisor.Add(new XElement("NombreComercial", facturaElectronica.Emisor.NombreComercial));
            XElement Ubicacion1 = new XElement("Ubicacion");
            Ubicacion1.Add(new XElement("Provincia", facturaElectronica.Ubicacion1.Provincia));
            Ubicacion1.Add(new XElement("Canton", facturaElectronica.Ubicacion1.Canton));
            Ubicacion1.Add(new XElement("Distrito", facturaElectronica.Ubicacion1.Distrito));
            Ubicacion1.Add(new XElement("OtrasSenas", facturaElectronica.Ubicacion1.OtrasSeñas));
            Emisor.Add(Ubicacion1);
            XElement Telefono1 = new XElement("Telefono");
            Telefono1.Add(new XElement("CodigoPais", facturaElectronica.Telefono1.CodigoPais));
            Telefono1.Add(new XElement("NumTelefono", facturaElectronica.Telefono1.NumeroTelefono));
            Emisor.Add(Telefono1);
            Emisor.Add(new XElement("CorreoElectronico", facturaElectronica.Emisor.Correo));
            nodoRaiz.Add(Emisor);
             XElement Receptor = new XElement("Receptor");
            Receptor.Add(new XElement("Nombre", facturaElectronica.Receptor.Nombre));
            XElement Identificacion2 = new XElement("Identificacion");
            Identificacion2.Add(new XElement("Tipo", facturaElectronica.Identificacion2.Tipo));
            Identificacion2.Add(new XElement("Numero", facturaElectronica.Identificacion2.Numero));
            Receptor.Add(Identificacion2);
            Receptor.Add(new XElement("NombreComercial", facturaElectronica.Receptor.NombreComercial));
            XElement Ubicacion2 = new XElement("Ubicacion");
            Ubicacion2.Add(new XElement("Provincia", facturaElectronica.Ubicacion2.Provincia));
            Ubicacion2.Add(new XElement("Canton", facturaElectronica.Ubicacion2.Canton));
            Ubicacion2.Add(new XElement("Distrito", facturaElectronica.Ubicacion2.Distrito));
            Ubicacion2.Add(new XElement("OtrasSenas", facturaElectronica.Ubicacion2.OtrasSeñas));
            Receptor.Add(Ubicacion2);
            XElement Telefono2 = new XElement("Telefono");
            Telefono2.Add(new XElement("CodigoPais", facturaElectronica.Telefono2.CodigoPais));
            Telefono2.Add(new XElement("NumTelefono", facturaElectronica.Telefono2.NumeroTelefono));
            Receptor.Add(Telefono2);
            Receptor.Add(new XElement("CorreoElectronico", facturaElectronica.Receptor.Correo));
            nodoRaiz.Add(Receptor);
            XElement CondicionVenta = new XElement("CondicionVenta", facturaElectronica.Encabezado.CondicionDeVenta);
            nodoRaiz.Add(CondicionVenta);
            XElement MedioPago = new XElement("MedioPago", facturaElectronica.Encabezado.IdMetodoPago);
            nodoRaiz.Add(MedioPago);
            XElement DetalleServicio = new XElement("DetalleServicio");
            XElement LineaDetalle = new XElement("LineaDetalle");
            LineaDetalle.Add(new XElement("NumeroLinea", facturaElectronica.LineaDeDetalle.NumeroDeLinea));
            LineaDetalle.Add(new XElement("Cantidad", facturaElectronica.LineaDeDetalle.Cantidad));
            LineaDetalle.Add(new XElement("UnidadMedida", facturaElectronica.LineaDeDetalle.UnidadMedida));
            LineaDetalle.Add(new XElement("Detalle", facturaElectronica.LineaDeDetalle.Detalle));
            LineaDetalle.Add(new XElement("PrecioUnitario", facturaElectronica.LineaDeDetalle.PrecioUnitario));
            LineaDetalle.Add(new XElement("MontoTotal", facturaElectronica.LineaDeDetalle.MontoTotal));
            LineaDetalle.Add(new XElement("SubTotal", facturaElectronica.LineaDeDetalle.Subtotal));
            XElement Impuesto = new XElement("Impuesto");
            Impuesto.Add(new XElement("Codigo", "01"));
            Impuesto.Add(new XElement("Monto", facturaElectronica.LineaDeDetalle.Impuesto));
            LineaDetalle.Add(Impuesto);
            LineaDetalle.Add(new XElement("MontoTotalLinea", facturaElectronica.LineaDeDetalle.MontoTotalLinea));
            DetalleServicio.Add(LineaDetalle);
            nodoRaiz.Add(DetalleServicio);
            xDocument.Save(@"c:\FacturaElectronica\NuevaFactura.xml");
      


        }
    }
}
