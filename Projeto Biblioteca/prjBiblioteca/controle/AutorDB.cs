using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class AutorDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void listar(System.Windows.Forms.ComboBox cb)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in banco.autor
                            orderby linha.idAutor
                            select linha;
                cb.DataSource = query.ToList();
                cb.DisplayMember = "nome";
                cb.ValueMember = "idAutor";
            }
        }

        public int proximoCodigo()
        {
            int t = 0;
            try
            {
                using(var banco = new modelo.bibliotecaEntidades()){
                    banco.Database.Connection.ConnectionString = con.open();
                    var query = (from linha in banco.autor
                                 select linha.idAutor).Max();
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

        public void inserir(modelo.autor novo)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.autor.Add(novo);
                    banco.SaveChanges();
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                string msg = "Lista de Erros ao adicionar registro: \n";
                foreach (var validationErros in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErros.ValidationErrors)
                    {
                        msg = String.Format("{0}\n", validationError.ErrorMessage);
                    }
                }
                System.Windows.Forms.MessageBox.Show("Erro: " + msg);
            }

            catch (System.Data.EntityException dbEx)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + dbEx.Message);
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
            {
                System.Windows.Forms.MessageBox.Show("Erro de adição de registro: " + dbEx.Message);
            }
        }

        public void editar(modelo.autor reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.autor autor = banco.autor.Single(qr => qr.idAutor == reg.idAutor);
                autor.nome = reg.nome;
                autor.nacionalidade = reg.nacionalidade;
                autor.nascimento = reg.nascimento;
                autor.ocupacao = reg.ocupacao;
                autor.telefone = reg.telefone;
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.autor reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.autor autor = banco.autor.Single(qr => qr.idAutor == reg.idAutor);
                banco.autor.Remove(autor);
                banco.SaveChanges();
            }
        }
    }
}
