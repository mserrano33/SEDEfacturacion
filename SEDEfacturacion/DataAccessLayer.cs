using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("link de coneccion")

        public void InsertCliente(Cliente contact)
        public List<Cliente> GetCliente()
        {
            try
            {
                conn.Open():
                string query "SELECT";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader():

                While (reader.Read())
                {
                    clientes.Add(new Cliente
                    {
                        Id = int.Parse(reader["Id"].ToString(),
                        ///FirstName cambiar continuar como guardar lista
                    });     
                 
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }

            return clientes;
        }
    }
}
