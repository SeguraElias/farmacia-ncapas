using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion.Proveedores
{
	public partial class index : System.Web.UI.Page
	{
		NProveedores proveedoresNegocio = new NProveedores();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				cargarProveedores();
			}
		}

		protected void cargarProveedores()
		{
			gvProveedores.DataSource = proveedoresNegocio.obtenerProveedores();
			gvProveedores.DataBind();
		}

        protected void gvProveedores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
			if (e.CommandName == "Actualizar")
			{
				int id = Convert.ToInt32(e.CommandArgument);
				Response.Redirect($"editProveedor.aspx?id={id}");
			}
			else if (e.CommandName == "Eliminar")
			{
				int id = Convert.ToInt32(e.CommandArgument);
				bool eliminado = proveedoresNegocio.eliminarProveedor(id);

				if (eliminado)
				{
					cargarProveedores();
				}
				else
				{
					ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se pudo eliminar el registro');", true);
				}
			}
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
			Response.Redirect("agregarProveedor.aspx");
        }
    }
}