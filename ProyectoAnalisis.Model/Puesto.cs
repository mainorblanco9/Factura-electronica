using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Model
{
    public enum Puesto
    {
        [Display(Name = "Usuario Adminstrador")]
        UsuarioAdministrador = 1,
        [Display(Name = "Servicio al cliente")]
        ServicioAlCliente = 2,
        [Display(Name = "Encarga de Ventas")]
        EncargadoDeVentas = 3,
        [Display(Name = "Encarga de Inventario")]
        EncargadoDeInventario = 4


    }
}
