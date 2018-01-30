using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class EditoraDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void listar(System.Windows.Forms.ComboBox cb)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in banco.editora
                            orderby linha.idEditora
                            select linha;
                cb.DataSource = query.ToList();
                cb.DisplayMember = "descricao";
                cb.ValueMember = "idEditora";
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
                    var query = (from linha in banco.editora
                                 select linha.idEditora).Max();
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

        public void inserir(modelo.editora novo)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.editora.Add(novo);
                    banco.SaveChanges();
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + err.Message);
            }
        }

        public void editar(modelo.editora reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.editora editora = banco.editora.Single(qr => qr.idEditora == reg.idEditora);
                editora.descricao = reg.descricao;
                editora.estado = reg.estado;
                editora.telefone = reg.telefone;
                editora.email = reg.email;
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.editora reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.editora editora = banco.editora.Single(qr => qr.idEditora == reg.idEditora);
                banco.editora.Remove(editora);
                banco.SaveChanges();
            }
        }
    }
}
