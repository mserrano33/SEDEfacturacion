using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()

        {
            _dataAccessLayer = new DataAccessLayer();
        }
        public Cliente SaveCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
                _dataAccessLayer.InsertCliente(cliente);
            //else
                //_dataAccessLayer.UpdateContact

                return cliente;

        }
    }
}
