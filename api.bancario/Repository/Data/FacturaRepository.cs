using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class FacturaRepository : IFactura
    {
        private IDbConnection conexionDB;

        public FacturaRepository(string _connectionString)
        {
            conexionDB = new DbConection(_connectionString).dbConnection();
        }

        public bool add(FacturaModel factura)
        {
            try
            {
                if (conexionDB.Execute("INSERT INTO Cliente(nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, sucursal) VALUES (@nro_factura, @fecha_hora, @total, @total_iva5, @total_iva10, @total_iva, @total_letras, @sucursal)", factura) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FacturaModel get(int id)
        {
            try
            {
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<FacturaModel> List()
        {
            throw new NotImplementedException();
        }

        public bool remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(FacturaModel factura)
        {
            try
            {
                if (conexionDB.Execute("UPDATE Factura SET " + "nro_factura=@nro_factura" + "fecha_hora=@fecha_hora", $"total=@total WHERE id_cliente = {id}" + "total_iva5=@total_iva5" + "total_iva10=@total_iva10" + "total_iva=@total_iva" + "total_letras=@total_letras" + "sucursal=@sucursal", factura) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
