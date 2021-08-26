using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAnalisis.Model
{
  public  class Ubicacion
    {
        public int Id { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public int Distrito { get; set; }
        [Display(Name ="Otras Señas ")]
        public string OtrasSeñas { get; set; }
    }
}
