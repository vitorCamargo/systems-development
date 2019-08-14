using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBiblioteca.visao
{
    public partial class FormMDI : Form
    {
        public visao.FormAluno frAluno = null;
        public visao.FormLivro frLivro = null;
        public visao.FormProfessor frProfessor = null;

        public FormMDI()
        {
            ThreadStart start = new ThreadStart(startBemVindo);
            Thread t = new Thread(start);
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        private void mnArquivoAlunos_Click(object sender, EventArgs e)
        {
            if (frAluno == null)
            {
                FormAluno fr = new FormAluno();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mnArquivoProfessores_Click(object sender, EventArgs e)
        {
            if (frProfessor == null)
            {
                FormProfessor fr = new FormProfessor();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mnArquivoSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?", "Alerta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    System.Environment.Exit(0);
            }
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            testarServidor();
            string server = controle.Registro.lerRegistro("biblioteca", "server");

            if (server == "")
            {
                visao.FormBancoDados frBD = new visao.FormBancoDados();
                frBD.ShowDialog();

                if (controle.Registro.lerRegistro("biblioteca", "server") == "")
                {
                    System.Environment.Exit(0);
                }
            }

            visao.FormLogin fr = new visao.FormLogin();
            fr.ShowDialog();

            loginUser.Text = "Conexão em " + DateTime.Now.ToShortDateString() +
                " as " + DateTime.Now.ToShortTimeString();

            loginHostname.Text = "Hostname: " + Environment.MachineName +
                " com Sistema Operacional " + Environment.OSVersion;
        }

        private void mnArquivoLivros_Click(object sender, EventArgs e)
        {
            if (frLivro == null)
            {
                frLivro = new visao.FormLivro();
                frLivro.MdiParent = this;
                frLivro.Show();
            }
        }

        private void testarServidor()
        {
            System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();

            try
            {
                client.Connect(controle.Registro.lerRegistro("biblioteca", "server"), 3306);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show("O endereço do servidor MySQL está fora do ar. " + ex.Message, "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                client.Close();
            }
        }

        public void startBemVindo()
        {
            Application.Run(new visao.FormWelcome());
        }
    }
}
