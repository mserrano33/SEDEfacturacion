﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    internal class Factura
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Id_cliente { get; set; }
        public string Id_Proveedor { get; set; }


        //_businessLogicLayer.SaveCliente(cliente);
    }
}
