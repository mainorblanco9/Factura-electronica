using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
  public class OperacionesDeInventario
    {
        public void AgregarUnProducto(Model.Producto producto)
        {
            var db = new Context();
            db.Producto.Add(producto);
            db.Entry(producto).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public List<Model.Producto> ListarProductos()
        {
            var db = new Context();
            var resultado = from c in db.Producto
                            select c;
            return resultado.ToList();
        }
        public void EditarProducto(Model.Producto producto){

            var db = new Context();
           
            db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public Model.Producto Consultar(int Id)
        {
         
            var db = new Context();
            var resultado = (db.Producto.Find(Id));
            return resultado;
        }
        public List<Model.ProductosFactura> dropdownlistProducto() {
           
            var db = new Context();
            var lista = (from c in db.Producto
                             select new Model.ProductosFactura
                             {
                                 Id= c.Id,
                                 Nombre= c.Nombre +" "+ c.Detalle
                             }).ToList();






            return lista;
        
        }
    
    }
}
