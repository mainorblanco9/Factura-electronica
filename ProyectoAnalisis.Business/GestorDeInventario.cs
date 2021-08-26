using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Business
{
   public class GestorDeInventario
    {
        public void RegistrarunProducto(Model.Producto producto)
        {
            DB.OperacionesDeInventario operacionesDeInventario  = new DB.OperacionesDeInventario();
            producto.Subtotal = CalcularSubtotal(producto);
            producto.IVA = CalcularImpuesto(producto);
            producto.Total = CalcularMontototal(producto);
            operacionesDeInventario.AgregarUnProducto(producto);
        }
        public decimal CalcularSubtotal(Model.Producto producto) {
            decimal i = 0;
            i = producto.Cantidad * producto.PrecioUnitario;
            return i;
        }
        public decimal CalcularMontototal(Model.Producto producto)
        {
            decimal i = 0;
            i = producto.Subtotal +  producto.IVA;
            return i;
        }
      
        public decimal CalcularImpuesto(Model.Producto producto)
        {
            decimal i = 0;

            i = (producto.Subtotal * Convert.ToDecimal(0.13));
            return i;
        }
        public List<Model.Producto> ListarProductos()
        {
            List<Model.Producto> laLista = new List<Model.Producto>();
            DB.OperacionesDeInventario operaciones = new DB.OperacionesDeInventario();
            laLista = operaciones.ListarProductos();
            return laLista;
        }
        public void EditarProducto(Model.Producto producto) {

            DB.OperacionesDeInventario operacionesDeInventario = new DB.OperacionesDeInventario();
            producto.Subtotal = CalcularSubtotal(producto);
            producto.IVA = CalcularImpuesto(producto);
            producto.Total = CalcularMontototal(producto);
            operacionesDeInventario.EditarProducto(producto);
        }
        public Model.Producto Consultar(int Id)
        {
            Model.Producto producto = new Model.Producto();
            DB.OperacionesDeInventario operacionesDeInventario = new DB.OperacionesDeInventario();
           producto= operacionesDeInventario.Consultar(Id);

            return producto;
        }
        public List<Model.ProductosFactura> dropdownlistProducto()
        {
            DB.OperacionesDeInventario operacionesDeInventario = new DB.OperacionesDeInventario();
            var lista = operacionesDeInventario.dropdownlistProducto();
            return lista;
        }

        }
}
