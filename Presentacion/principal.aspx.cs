﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
	public partial class Principal : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnProveedores_Click(object sender, EventArgs e)
        {
			Response.Redirect("Proveedores/index.aspx");
        }
    }
}