using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDEfacturacion
{
    private DataAccessLayer _dataAccessLayer;/// corregir error buscar en google
    /// 
    /// </summary>
    public class BusinessLogicLayer()
    {
        _dataAccessLayer = new DataAccessLayer();
    }
    public Cliente SaveCliente(Cliente cliente)
{
    if (contact.Id == 0)
        _dataAccessLayer.IsertCliente(cliente);
    //else
    //_dataAccessLayer.UpdateContact

    return contact;
}

}
