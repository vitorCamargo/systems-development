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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            controle.UsuarioDB uDB = new controle.UsuarioDB();
            if (uDB.validar(txtLogin.Text, txtSenha.Text))
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Conexão Inválida");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
