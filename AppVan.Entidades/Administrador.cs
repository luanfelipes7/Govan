using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVan.Entidades
{
    public class Administrador
    {
        private int id;
        private string user;
        private string senha;

        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
