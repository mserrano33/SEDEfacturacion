using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    internal class Caja
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string CajaInicial { get; set; }
        public string Entrada{ get; set; }
        public string Salida { get; set; }

        //_businessLogicLayer.SaveCliente(cliente);
    }
}
