using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBiblioteca.controle
{
    class ProfessorDB
    {
        Conexao con = new Conexao("localhost", "biblioteca", "root", "minas");

        public void carregarTabela(System.Windows.Forms.BindingSource bs)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();

                var query = from linha in banco.professor
                            orderby linha.idprofessor
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
                    var query = (from linha in banco.professor
                                 select linha.idprofessor).Max();
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

        public void inserir(modelo.professor professor)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    banco.professor.Add(professor);
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

        public void editar(modelo.professor prof)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    modelo.professor reg = (from linha in banco.professor
                                           where linha.idprofessor == prof.idprofessor
                                           select linha).FirstOrDefault<modelo.professor>();

                    reg.nome = prof.nome;
                    reg.fone = prof.fone;
                    reg.idcurso = prof.idcurso;
                    reg.email = prof.email;
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

        public void excluir(int cod)
        {
            try
            {
                using (var banco = new modelo.bibliotecaEntidades())
                {
                    banco.Database.Connection.ConnectionString = con.open();
                    var prof = banco.professor.First(a => a.idprofessor == cod);
                    banco.professor.Remove(prof);
                    banco.SaveChanges();
                }
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

        public void filtrar(System.Windows.Forms.DataGridView dg, string p)
        {
            using (var banco = new modelo.bibliotecaEntidades())
            {
                banco.Database.Connection.ConnectionString = con.open();
                var reg = from linha in banco.professor
                          where linha.nome.Contains(p)
                          orderby linha.nome
                          select new { linha.idprofessor, linha.nome };

                dg.DataSource = reg.ToList();
                dg.Columns[1].Width = 500;
                dg.Columns[0].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dg.Columns[1].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
