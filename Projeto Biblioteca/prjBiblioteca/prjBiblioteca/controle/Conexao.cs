using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class Conexao
    {
        private string path;
        private string database;
        private string login;
        private string senha;

        public Conexao(string path, string database, string login, string senha)
        {
            this.path = path;
            this.database = database;
            this.login = login;
            this.senha = senha;
        }

        public String open()
        {
            string strcon = "server = " + path + ";"
                + "user id = " + login + ";"
                + "database = " + database + ";"
                + "password = " + senha + ";"
                + "persist security info=true";
            return strcon;
        }
    }
}
