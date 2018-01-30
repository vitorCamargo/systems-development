using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjBiblioteca.controle
{
    class AlunoDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void consultar(System.Windows.Forms.BindingSource bs)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in banco.aluno.Include("curso")
                            orderby linha.idaluno
                            select linha;

                bs.DataSource = query.ToList();
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
                    var query = (from linha in banco.aluno
                                 select linha.idaluno).Max();
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

        public void inserir(modelo.aluno novo)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.aluno.Add(novo);
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

        public void excluir(modelo.aluno reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.aluno aluno = banco.aluno.Single(qr => qr.idaluno == reg.idaluno);
                banco.aluno.Remove(aluno);
                banco.SaveChanges();
            }
        }

        public modelo.aluno procurar(modelo.aluno reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.aluno aluno = banco.aluno.Single(qr => qr.idaluno == reg.idaluno);
                return aluno;
            }    
        }

        public void editar(modelo.aluno reg)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                modelo.aluno aluno = banco.aluno.Single(qr => qr.idaluno == reg.idaluno);
                aluno.nome = reg.nome;
                aluno.nascimento = reg.nascimento;
                aluno.fone = reg.fone;
                aluno.numero = reg.numero;
                aluno.uf = reg.uf;
                aluno.bairro = reg.bairro;
                aluno.cidade = reg.cidade;
                aluno.cep = reg.cep;
                aluno.email = reg.email;
                aluno.sala = reg.sala;
                banco.SaveChanges();
            } 
        }

        public void filtrar(System.Windows.Forms.DataGridView dg, string p)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var reg = from linha in banco.aluno
                          where linha.nome.Contains(p)
                          orderby linha.nome
                          select new { linha.idaluno, linha.nome };

                dg.DataSource = reg.ToList();
                dg.Columns[1].Width = 500;
                dg.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dg.Columns[1].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            }
        }

        public bool checarCurso(string p)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                int cod = Int16.Parse(p);
                var query = (from linha in banco.aluno
                             where linha.idcurso == cod
                             select linha).FirstOrDefault();
                if (query == null) return false;
                return true;
            }
        }

        public void imprimir(System.Data.DataSet ds)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var query = from linha in banco.aluno
                            orderby linha.nome
                            select new
                            {
                                linha.idaluno,
                                linha.nome,
                                linha.sala,
                                linha.cidade,
                                linha.curso.descricao
                            };

                ds.Tables.Add(new System.Data.DataTable());
                ds.Tables[0].Columns.Add("idaluno");
                ds.Tables[0].Columns.Add("nome");
                ds.Tables[0].Columns.Add("sala");
                ds.Tables[0].Columns.Add("cidade");
                ds.Tables[0].Columns.Add("curso");

                foreach (var a in query)
                {
                    System.Data.DataRow row = ds.Tables[0].NewRow();
                    row["idaluno"] = a.idaluno;
                    row["nome"] = a.nome;
                    row["sala"] = a.sala;
                    row["cidade"] = a.cidade;
                    row["curso"] = a.descricao;
                    ds.Tables[0].Rows.Add(row);
                }
                ds.DataSetName = "dsAluno";
            }
        }
    }
}
