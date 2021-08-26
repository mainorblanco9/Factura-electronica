using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
    public class Distrito
    {
        public int IdProvincia { get; set; }
        public string IdCanton { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
