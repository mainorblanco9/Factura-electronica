using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAnalisis.Model
{
    public  class Emisor
    {
        public int Id { get; set; }
      
        [Display(Name = "Nombre completo")]
        public string Nombre { get; set; }

        public int Identificacion { get; set; }

        [Display(Name = "Nombre comercial")]
        public string NombreComercial { get; set; }
        public int Ubicacion { get; set; }
        [Display(Name = "Telefono")]
        public int Telefono { get; set; }
       
        [Display(Name = "Correo")]
        public string Correo { get; set; }
       

        
        

    }
}
