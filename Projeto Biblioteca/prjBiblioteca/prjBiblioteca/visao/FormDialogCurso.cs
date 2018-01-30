using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBiblioteca.modelo
{
    public partial class FormDialogCurso : Form
    {
        private modelo.curso curso;

        public modelo.curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public FormDialogCurso()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Curso = null;
            this.Dispose();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Curso == null)
                {
                    novo();
                }
                else
                {
                    this.Dispose();
                }
            }
            catch (EntityException err)
            {
                MessageBox.Show("ERRO DO EF: " + err.Message);
            }
        }

        private void novo()
        {
            controle.cursoBD cDB = new controle.cursoBD();
            Curso = new modelo.curso(){
                idcurso = cDB.proximoCodigo(),
                descricao = txtNome.Text.ToUpper()
            };
            cDB.inserir(Curso);
        }

        private void editar()
        {
            controle.cursoBD cDB = new controle.cursoBD();
            Curso.descricao = txtNome.Text.ToUpper();
            cDB.editar(Curso);
        }

        private void FormDialogCurso_Load(object sender, EventArgs e)
        {
            if (Curso != null)
            {
                txtNome.Text = Curso.descricao;
            }
        }
    }
}
