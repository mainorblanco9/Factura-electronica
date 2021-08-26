using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Business
{
   public class GestorDeUbicacion
    {
        public List<Model.Provincia> ListarProvincia()
        {
            List<Model.Provincia> laLista = new List<Model.Provincia>();
            DB.OperacionesDeUbicacion operaciones = new DB.OperacionesDeUbicacion();
            laLista = operaciones.ListarProvincia();
            return laLista;
        }
        
        public List<Model.Distrito> ListarDistrito()
        {
            List<Model.Distrito> laLista = new List<Model.Distrito>();
            DB.OperacionesDeUbicacion operaciones = new DB.OperacionesDeUbicacion();
            laLista = operaciones.ListarDistrito();
            return laLista;
        }

    }
}
