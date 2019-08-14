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
    public partial class FormEditora : Form
    {
        private modelo.editora editora;

        public modelo.editora Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public FormEditora()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Editora == null) novo();
            else editar();
            this.Dispose();
        }

        private void novo()
        {
            controle.EditoraDB eDb = new controle.EditoraDB();
            Editora = new modelo.editora()
            {
                idEditora = eDb.proximoCodigo(),
                descricao = txtDescricao.Text,
                estado = cbEstado.Text,
                telefone = txtTelefone.Text,
                email = txtEmail.Text
            };
            eDb.inserir(Editora);
        }

        private void editar()
        {
            controle.EditoraDB eDb = new controle.EditoraDB();
            Editora.descricao = txtDescricao.Text;
            Editora.estado = cbEstado.Text;
            Editora.telefone = txtTelefone.Text;
            Editora.email = txtEmail.Text;
            eDb.editar(Editora);
        }
    }
}
