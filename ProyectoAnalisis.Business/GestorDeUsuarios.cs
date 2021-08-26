using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Business
{
  public  class GestorDeUsuarios
    {
        public void RegistrarunUsuario(Model.Usuarios usuarios)
        {
            DB.OperacionesDeUsuarios operacionesDeUsuarios = new DB.OperacionesDeUsuarios();
            operacionesDeUsuarios.AgregarUnUsuario(usuarios);
        }
        public List<Model.Usuarios> ListarUsuarios()
        {
            List<Model.Usuarios> laLista = new List<Model.Usuarios>();
            DB.OperacionesDeUsuarios operaciones = new DB.OperacionesDeUsuarios();
            laLista = operaciones.ListarUsuarios();
            return laLista;
        }

        public Model.Usuarios consultar(string correo)
        {
            DB.OperacionesDeUsuarios operacionesDeUsuarios = new DB.OperacionesDeUsuarios();


            return operacionesDeUsuarios.Consultar(correo);

        }
    }
}
