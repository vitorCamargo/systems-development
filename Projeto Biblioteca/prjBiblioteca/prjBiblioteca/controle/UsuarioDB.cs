using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class UsuarioDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public bool validar(string nome, string senha)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = (from linha in banco.usuarios
                             where linha.login.Equals(nome) &&
                             linha.senha.Equals(senha)
                             select linha).FirstOrDefault();
                if (query == null) return false;
                return true;
            }
        }
    }
}
