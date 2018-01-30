using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class GeneroDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void listar(System.Windows.Forms.ComboBox cb)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in banco.genero
                            orderby linha.idGenero
                            select linha;
                cb.DataSource = query.ToList();
                cb.DisplayMember = "descricao";
                cb.ValueMember = "idGenero";
            }
        }

        public int proximoCodigo()
        {
            int t = 0;
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    var query = (from linha in banco.genero
                                 select linha.idGenero).Max();
                    t = Convert.ToInt16(query.ToString());
                }
                return t + 1;
            }
            catch (Exception err)
            {
                System.Console.WriteLine(err.Message);
                return 1;
            }
        }

        public void inserir(modelo.genero novo)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.genero.Add(novo);
                    banco.SaveChanges();
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + err.Message);
            }
        }

        public void editar(modelo.genero reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.genero genero = banco.genero.Single(qr => qr.idGenero == reg.idGenero);
                genero.descricao = reg.descricao;
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.genero reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.genero genero = banco.genero.Single(qr => qr.idGenero == reg.idGenero);
                banco.genero.Remove(genero);
                banco.SaveChanges();
            }
        }
    }
}
