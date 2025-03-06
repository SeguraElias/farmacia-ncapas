using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Proveedores
{
	public partial class agregarProveedor : System.Web.UI.Page
	{
        NProveedores proveedoresNegocio = new NProveedores();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
			Response.Redirect("index.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;

            bool exito = proveedoresNegocio.agregarProveedor(nombre, telefono, direccion, correo);
            if (exito)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('Error al agregar proveedor');</script>");
            }
        }
    }
}