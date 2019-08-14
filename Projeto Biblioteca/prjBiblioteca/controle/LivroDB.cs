using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.API.Search;

namespace prjBiblioteca.controle
{
    class LivroDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void consultar(System.Windows.Forms.BindingSource bs)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in
                            banco.livro
                            .Include("autor").Include("editora")
                            .Include("genero").Include("autor")
                            orderby linha.idLivro
                            select linha;

                bs.DataSource = query.ToList();
            }
        }

        public void inserir(modelo.livro novo){
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.livro.Add(novo);
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

        public void editar(modelo.livro reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.livro livro = banco.livro.Single(qr => qr.idLivro == reg.idLivro);
                livro.idEditora = reg.idEditora;
                livro.idGenero = reg.idGenero;
                livro.idAutor = reg.idAutor;
                livro.titulo = reg.titulo;
                livro.edicao = reg.edicao;
                livro.nrpaginas = reg.nrpaginas;
                livro.resumo = reg.resumo;
                livro.publicacao = reg.publicacao;
                livro.codisbn = reg.codisbn;
                banco.SaveChanges();
            }
        }

        public void excluir(modelo.livro reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.livro livro = banco.livro.Single(qr => qr.idLivro == reg.idLivro);
                banco.livro.Remove(livro);
                banco.SaveChanges();
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
                    var query = (from linha in banco.livro
                                 select linha.idLivro).Max();
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

        public modelo.livro procurar(modelo.livro reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                modelo.livro livro = banco.livro.Single(qr => qr.idLivro == reg.idLivro);
                return livro;
            }
        }

        public void procurarLivroGoogle(string isbn, modelo.livro livro)
        {
            GbookSearchClient cliente = new GbookSearchClient("www.etecitapeva.com.br");

            string nomeautor = "";
            IList<IBookResult> resultados = cliente.Search(isbn, 1);

            if (resultados.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("ISBN não localizado para o livro");
                livro = null;
                return;
            }
            try
            {
                foreach (IBookResult resultado in resultados)
                {
                    livro.titulo = resultado.Title.ToString();
                    nomeautor = resultado.Authors.ToString();
                    livro.resumo = "Livro de " + nomeautor;
                    livro.codisbn = resultado.BookId.ToString();
                    livro.publicacao = new DateTime(Int16.Parse(resultado.PublishedYear), 1, 1);
                    livro.nrpaginas = Int16.Parse(resultado.PageCount.ToString());
                }
            }
            catch (FormatException)
            {
                livro.publicacao = DateTime.Today;
                livro.nrpaginas = 0;
            }
        }

        public void filtrar(System.Windows.Forms.DataGridView dg, string p)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var reg = from linha in banco.livro
                          where linha.titulo.Contains(p)
                          orderby linha.titulo
                          select new { linha.idLivro, linha.titulo };

                dg.DataSource = reg.ToList();
                dg.Columns[1].Width = 500;
                dg.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dg.Columns[1].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            }
        }

        public void imprimir(System.Data.DataSet ds)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var query = from linha in banco.livro
                            orderby linha.titulo
                            select new
                            {
                                linha.idLivro,
                                linha.titulo,
                                linha.autor
                            };

                ds.Tables.Add(new System.Data.DataTable());
                ds.Tables[0].Columns.Add("idLivro");
                ds.Tables[0].Columns.Add("titulo");
                ds.Tables[0].Columns.Add("autor");

                foreach (var a in query)
                {
                    System.Data.DataRow row = ds.Tables[0].NewRow();
                    row["idLivro"] = a.idLivro;
                    row["titulo"] = a.titulo;
                    row["autor"] = a.autor;
                    ds.Tables[0].Rows.Add(row);
                }
                ds.DataSetName = "dsLivro";
            }
        }
    }
}
