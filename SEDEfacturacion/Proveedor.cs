using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    internal class Proveedor
    {
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        

        //_businessLogicLayer.SaveCliente(cliente);
    }
}
