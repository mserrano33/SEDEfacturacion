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
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=polirubro; Data Source=LAPTOP-MTOM31PT");

        public void InsertCliente(Cliente cliente)      ///coneccion e insert cliente
        
        {
            try    
            {
                conn.Open();                ///abre coneccion, consulta sql insert tabla y valores
                string query =@"
                                 INSERT INTO Clientes(Nombre, DNI, Direccion, Telefono, Estado)
                                 VALUES (@Nombre, @DNI, @Direccion, @Telefono, @Estado)";
                SqlParameter Nombre = new SqlParameter();       
                Nombre.ParameterName = "@Nombre";
                Nombre.Value = cliente.Nombre;
                Nombre.DbType = System.Data.DbType.String;

                SqlParameter DNI = new SqlParameter("@DNI", cliente.DNI);///
                SqlParameter Direccion = new SqlParameter("@Direccion", cliente.Direccion);
                SqlParameter Telefono = new SqlParameter("@Telefono", cliente.Telefono);
                SqlParameter Estado = new SqlParameter("@Estado", cliente.Estado);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Nombre);///agrega parametro a atributos
                command.Parameters.Add(DNI);
                command.Parameters.Add(Direccion);
                command.Parameters.Add(Telefono);
                command.Parameters.Add(Estado);

                command.ExecuteNonQuery();


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

        public List<Cliente> GetClientes() 
        {
            List<Cliente> clientes = new List<Cliente>();///metodo para grilla
            try
            {
                conn.Open();                ///consulta de tabla en sql
                string query = @" SELECT Id Nombre, DNI, Direccion, Telefono, Estado
                                FROM Clientes";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())//bucle de iteracion
                {
                    clientes.Add(new Cliente        ///declara que tiene qeu cargar
                    {
                        Id = int.Parse(reader["Id"].ToString()),///itera en coumna y carga a propiedad
                        Nombre = reader["Nombre"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Estado = reader["Estado"].ToString(),
                    });

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }       ///finaliza coneccion

            return clientes;
        }
    }
}
