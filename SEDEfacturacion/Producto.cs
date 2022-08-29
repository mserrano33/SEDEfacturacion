using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; }
        public string PrecioCosto { get; set; }
        public string PrecioVentta { get; set; }
        public string Id_Categoria { get; set; }

        //_businessLogicLayer.SaveCliente(cliente);
    }
}
