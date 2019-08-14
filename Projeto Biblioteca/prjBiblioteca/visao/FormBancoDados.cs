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
    public partial class FormBancoDados : Form
    {
        public FormBancoDados()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            controle.Registro.criaRegistro("biblioteca", "server", Servidor.Text);
            controle.Registro.criaRegistro("biblioteca", "user", txtUser.Text);
            controle.Registro.criaRegistro("biblioteca", "password", txtPassword.Text);
            MessageBox.Show("Dados Gravados com sucesso...");
            this.Dispose();
        }
    }
}
