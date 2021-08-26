using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis.Business
{
  public  class GestorDeCliente
    {
        public void RegistrarUnCliente(Model.Cliente cliente)
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            operacionesDeCliente.AgregarUnCliente(cliente);
        }
        public List<Model.Cliente> ListarClientes()
        {
            List<Model.Cliente> laLista = new List<Model.Cliente>();
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            laLista = operacionesDeCliente.ListarClientes();
            return laLista;
        }
        public void EditarCliente(Model.Cliente cliente)
        {

            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();

            operacionesDeCliente.EditarCliente(cliente);
        }
        public Model.Cliente Consultar(int Id)
        {
            Model.Cliente cliente = new Model.Cliente();
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            cliente = operacionesDeCliente.Consultar(Id);

            return cliente;
        }
        public List<Model.ElementJsonIntKey> DropdownlistCliente()
        {
            DB.OperacionesDeCliente operacionesDeCliente = new DB.OperacionesDeCliente();
            var lista = operacionesDeCliente.dropdownlistreceptor();
            return lista;
        }

    }
}
