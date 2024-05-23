using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ClienteService
    {
        ClienteRepository clienteRepository;
        
        public ClienteService(string connectionString)
        {
            clienteRepository = new ClienteRepository(connectionString);
        }

       
public bool add(ClienteModel modelo)
        {
            if (validacionCliente(modelo))
            return clienteRepository.add(modelo);
            else 
                return false;
        }

        private bool validacionCliente(ClienteModel cliente)
        {
            if (cliente == null)
                return false;
            if (string.IsNullOrEmpty(cliente.nombre))
                return false;
            return true;
        }
 
    }
}
