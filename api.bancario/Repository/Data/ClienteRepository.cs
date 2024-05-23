using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class ClienteRepository : ICliente
    {
        private IDbConnection conexionDB;

        public ClienteRepository(string _connectionString)
        {
            conexionDB = new DbConection(_connectionString).dbConnection();
        }

        public bool add(ClienteModel cliente)
        {
            try
            {
                if (conexionDB.Execute("INSERT INTO Cliente(nombre, apellido, documento, direccion, mail, celular, estado) VALUES (@nombre, @apellido, @documento, @direccion, @mail, @celular, @estado)", cliente) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClienteModel get(int id)
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

        public IEnumerable<ClienteModel> List()
        {
            throw new NotImplementedException();
        }

        public bool remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(ClienteModel cliente, int id)
        {
            try
            {
                if (conexionDB.Execute("UPDATE Cliente SET " + "nombre=@nombre" + "apellido=@apellido", $"documento=@documento WHERE id_cliente = {id}" + "direccion=@direccion" + "mail=@mail" + "celular=@celular" + "estado=@estado", cliente) > 0)
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
