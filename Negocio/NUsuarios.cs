using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NUsuarios
    {
        Usuarios dataUsuarios = new Usuarios();

        public string Login(string user, string pass)
        {
            if(dataUsuarios.validateUser(user, pass))
            {
                return "ok";
            }
            else
            {
                return "User not found";
            }
        }
    }
}
