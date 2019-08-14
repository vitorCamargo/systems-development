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
    public partial class FormDialogPesquisarProfessor : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public FormDialogPesquisarProfessor()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lbProfessor.Text.Equals(""))
            {
                MessageBox.Show("Selecione um professor válido");
            }
            else
            {
                Dispose();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            controle.ProfessorDB aDB = new controle.ProfessorDB();
            aDB.filtrar(dg, txtNome.Text);
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Id = Int16.Parse(dg.CurrentRow.Cells[0].Value.ToString());
                lbProfessor.Text = dg.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                this.Id = 0;
                txtNome.Text = "";
            }
        }
    }
}
