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
                                 INSERT INTO Clientes(Nombre, DNI, Direccion, Telefono, Id_estado)
                                 VALUES (@Nombre, @DNI, @Direccion, @Telefono, Id_estado)";
                SqlParameter Nombre = new SqlParameter();
                Nombre.ParameterName = "@Nombre";
                Nombre.Value = cliente.Nombre;
                Nombre.DbType = System.Data.DbType.String;

                SqlParameter DNI = new SqlParameter("@DNI", cliente.DNI);
                SqlParameter Direccion = new SqlParameter("@Direccion", cliente.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", cliente.Telefono);
                SqlParameter Id_estado = new SqlParameter("@Id_estado", cliente.Id_estado);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Nombre);
                command.Parameters.Add(DNI);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Id_estado);


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
