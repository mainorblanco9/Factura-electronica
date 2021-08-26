using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.DB
{
  public  class OperacionesDeCierres
    {
        public void AgregarUnCierre(Model.Cierres cierres)
        {
            var db = new Context();
            db.Cierres.Add(cierres);
            db.Entry(cierres).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public List<Model.Cierres> ListarCierres()
        {
            var db = new Context();
            var resultado = from c in db.Cierres
                            select c;
            return resultado.ToList();
        }
    }
}
