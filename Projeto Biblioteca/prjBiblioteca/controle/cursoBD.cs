using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class cursoBD
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void listar(System.Windows.Forms.ComboBox cb)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var query = from linha in banco.curso
                             orderby linha.descricao
                             select linha;
                cb.DataSource = query.ToList();
                cb.DisplayMember = "descricao";
                cb.ValueMember = "idCurso";
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
                    var query = (from linha in banco.curso
                                 select linha.idcurso).Max();
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

        public void excluir(modelo.curso reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.curso curso = banco.curso.Single(qr => qr.idcurso == reg.idcurso);
                banco.curso.Remove(curso);
                banco.SaveChanges();
            }
        }

        public void editar(modelo.curso reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.curso curso = banco.curso.Single(qr => qr.idcurso == reg.idcurso);

                curso.descricao = reg.descricao;
                banco.SaveChanges();
            }
        }

        public void inserir(modelo.curso novo)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.curso.Add(novo);
                    banco.SaveChanges();
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + err.Message);
            }
        }
    }
}
