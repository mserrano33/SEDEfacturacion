using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Securty Info=False;Initial Catalog=polirubro;Data suource=LAPTOP-MTOM31PT");

        public void InsertCliente(Cliente cliente)
        
        {
            try
            {
                conn.Open();
                string query =@"
                                 INSERT INTO Clientes(Nombre, DNI, Direccion,
                                 Telefono, Id_estado)";


                SqlCommand comand = new SqlCommand(query, conn);
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                conn.Close(); 
            }

            
        }
    }
}
