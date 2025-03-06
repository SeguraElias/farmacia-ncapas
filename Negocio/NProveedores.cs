using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NProveedores
    {
        Proveedores objproveedores = new Proveedores();

        public DataTable obtenerProveedores()
        {
            return objproveedores.getProveedores();
        }

        public bool agregarProveedor(string nombre, string telefono, string direccion, string correo)
        {
            return objproveedores.addProveedor(nombre, telefono, direccion, correo);
        }

        public bool actualizarProveedor(int id, string nombre, string telefono, string direccion, string correo)
        {
            return objproveedores.updateProveedor(id, nombre, telefono, direccion, correo);
        }

        public bool eliminarProveedor(int id)
        {
            return objproveedores.deleteProveedor(id);
        }
    }
}
