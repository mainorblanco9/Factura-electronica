using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
   public  class OperacionesDeCliente
    {
        public void AgregarUnCliente(Model.Cliente cliente)
        {
            var db = new Context();
            db.Entry(cliente).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

       
        public List<Model.Cliente> ListarClientes()
        {
            var db = new Context();
            var resultado = from c in db.Cliente
                            select c;
            return resultado.ToList();
        }
        public Model.Telefono Consultartelefono()
        {

            var db = new Context();
            var listar = from c in db.Telefono
                         select c;
            Model.Telefono Telefono = new Model.Telefono();
            List<Model.Telefono> Telefonolist = new List<Model.Telefono>();
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
            List<Model.Identificacion> LineaDeDetallelist = new List<Model.Identificacion>();
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
        public Model.Ubicacion Consultarubicacion()
        {

            var db = new Context();
            var listar = from c in db.Ubicacion
                         select c;
            Model.Ubicacion lineaDeDetalle = new Model.Ubicacion();
            List<Model.Ubicacion> LineaDeDetallelist = new List<Model.Ubicacion>();
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
        public void EditarCliente(Model.Cliente cliente)
        {

            var db = new Context();

            db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
           
        }
        public Model.Cliente Consultar(int Id)
        {

            var db = new Context();
            
            var resultado = (db.Cliente.Find(Id));
           
            
            return resultado;
        }
        public List<Model.ElementJsonIntKey> dropdownlistreceptor()
        {

            var db = new Context();
            var lista = (from c in db.Cliente
                         select new Model.ElementJsonIntKey
                         {
                             Id = c.Id,
                             Nombre =  c.Nombre.ToString()+"-"+c.Numero.ToString()
                         }).ToList();






            return lista;

        }
    }
}
