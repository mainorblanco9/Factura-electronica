using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
   public  class OperacionesDeUbicacion
    {
        public List<Model.Provincia> ListarProvincia()
        {
            var db = new Context();
            var resultado = from c in db.Provincia
                            select c;
            return resultado.ToList();
        }
        public List<Model.Canton> ListarCanton(int provincia)
        {
            var db = new Context();
            var resultado = from c in db.Canton
                            where c.IdProvincia== provincia
                            select c;
            return resultado.ToList();
        }
      
        public List<Model.Distrito> ListarDistrito()
        {
            var db = new Context();
            var resultado = from c in db.Distrito
                            select c;
            return resultado.ToList();
        }


    }
}
