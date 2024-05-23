using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class FacturaService
    {
        FacturaRepository facturaRepository;

        public FacturaService(string connectionString) 
        {
            facturaRepository = new FacturaRepository(connectionString);
        }


    }


}


