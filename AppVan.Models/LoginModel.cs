using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVan.Controller;
using AppVan.Entidades;

namespace AppVan.Models
{
    public class LoginModel
    {
        private string aviso = "";
        public string acessar(Administrador u)
        {
            LoginDao login = new Controller.LoginDao();
            bool valor = login.verificaLogin(u.User, u.Senha);
            if (!valor)
            {
                aviso = "Login ou Senha não válido";
            }
            return aviso;
        }
    }
}
