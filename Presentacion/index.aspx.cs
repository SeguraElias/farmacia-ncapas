using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
	public partial class index : System.Web.UI.Page
	{
		NUsuarios nusuario = new NUsuarios();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnLogin_Click(object sender, EventArgs e)
        {
			string user = txtUser.Text.Trim();
			string pass = txtPass.Text.Trim();

			string res = nusuario.Login(user, pass);

			if (res == "ok")
			{
				Response.Redirect("principal.aspx");
			}
			else
			{
				Response.Write("Usuario y/o password incorrectos");
			}
        }
    }
}