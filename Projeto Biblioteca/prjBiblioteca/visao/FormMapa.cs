using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBiblioteca.visao
{
    public partial class FormMapa : Form
    {
        private modelo.aluno aluno;

        public modelo.aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public FormMapa()
        {
            InitializeComponent();
        }

        private void FormMapa_Load(object sender, EventArgs e)
        {
            string endereco = Aluno.endereco + "," + Aluno.numero.ToString();

            lbEndereco.Text = Aluno.nome + "\n" +
                endereco + "\n" + Aluno.bairro + "\n" +
                Aluno.cidade + "  " + Aluno.cep +
                "\n" + Aluno.email;

            try
            {
                StringBuilder query = new StringBuilder();

                query.Append("http://google.com/maps?q=");

                if (endereco != String.Empty)
                {
                    query.Append(endereco + "," + "+");
                }

                if (Aluno.cidade != String.Empty)
                {
                    query.Append(Aluno.cidade + "," + "+");
                }

                if (Aluno.uf != String.Empty)
                {
                    query.Append(Aluno.uf + "," + "+");
                }

                if (Aluno.cep != String.Empty)
                {
                    query.Append(Aluno.cep + "," + "+"); 
                }
                query.Append("Brasil");

                webBrowser1.Navigate(query.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar a internet... Tente mais tarde");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
