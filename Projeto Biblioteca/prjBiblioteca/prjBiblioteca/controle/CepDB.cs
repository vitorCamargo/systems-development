using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class CepDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public modelo.tend_endereco consultar(string cep)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = (from linha in banco.tend_endereco.
                                 Include("tend_bairro").Include("tend_cidade")
                             where linha.cep.Equals(cep)
                             select linha).FirstOrDefault();
                if (query == null) return null;
                else
                    return (modelo.tend_endereco)query;
            }
        }
    }
}
