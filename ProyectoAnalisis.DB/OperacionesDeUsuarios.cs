using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
  public  class OperacionesDeUsuarios
    {
        public void AgregarUnUsuario(Model.Usuarios usuarios)
        {
            var db = new Context();
            db.Usuarios.Add(usuarios);
            db.Entry(usuarios).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public List<Model.Usuarios> ListarUsuarios()
        {
            var db = new Context();
            var resultado = from c in db.Usuarios
                            select c;
            return resultado.ToList();
        }
        public Model.Usuarios Consultar(string correo)
        {

            var db = new Context();
            var resultado = from c in db.Usuarios
                            select c;
            List<Model.Usuarios> usuarios = new List<Model.Usuarios>();
            usuarios = resultado.ToList();
            Model.Usuarios usuarios1 = new Model.Usuarios();
            foreach (var item in usuarios)
            {

                if (item.Correo.Equals(correo))
                {
                    usuarios1 = item;
                }

            }


            return usuarios1;
        }
    }
}
