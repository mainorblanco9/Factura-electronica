using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Business
{
    public class GestorDeCierres
    {
        public void CrearCierre(Model.Cierres cierres)
        {
            DB.OperacionesDeCierres operacionesDeCierres = new DB.OperacionesDeCierres();
            DB.OperacionesDeFactura operacionesDeFactura = new DB.OperacionesDeFactura();
           
            cierres.FechaDeEmision = DateTime.Today.Date;
            cierres.MontoToTal = operacionesDeFactura.SumatoriaMontoTotal();
            operacionesDeCierres.AgregarUnCierre(cierres);

        }
        public List<Model.Cierres> ListarCierres()
        {
            List<Model.Cierres> laLista = new List<Model.Cierres>();
            DB.OperacionesDeCierres operaciones = new DB.OperacionesDeCierres();
            laLista = operaciones.ListarCierres();
            return laLista;
        }
    }
}
