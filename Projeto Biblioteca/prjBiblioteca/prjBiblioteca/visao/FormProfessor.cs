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
    public partial class FormProfessor : Form
    {
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            controle.ProfessorDB pDB = new controle.ProfessorDB();
            pDB.carregarTabela(bs);

            controle.cursoBD cDB = new controle.cursoBD();
            cDB.listar(cbCurso);

            if (bs.Count != 0)
            {
                bs.MoveFirst();
                habilitarCampos(true);
                btnCancel.Enabled = false;
            }
            else
            {
                btnDel.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;

                habilitarCampos(false);
            }
            vincularCampos();
            this.Cursor = Cursors.Default;
        }

        private void habilitarCampos(bool status)
        {
            txtNome.Enabled = status;
            txtFone.Enabled = status;
            txtEmail.Enabled = status;
            cbCurso.Enabled = status;
            btnPesquisar.Enabled = status;
            txtCod.Enabled = status;
        }

        private void vincularCampos()
        {
            lbCod.DataBindings.Add(new Binding("Text", bs, "idprofessor"));
            txtNome.DataBindings.Add(new Binding("Text", bs, "nome"));
            txtFone.DataBindings.Add(new Binding("Text", bs, "fone"));
            txtEmail.DataBindings.Add(new Binding("Text", bs, "email"));
            cbCurso.DataBindings.Add(new Binding("SelectedValue", bs, "idCurso"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            habilitarCampos(true);

            btnDel.Enabled = false;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            bs.AddNew();

            controle.ProfessorDB pDB = new controle.ProfessorDB();

            lbCod.Focus();
            lbCod.Text = pDB.proximoCodigo().ToString();

            cbCurso.Focus();
            cbCurso.SelectedIndex = 0;

            txtNome.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnCancel.Enabled == true)
            {
                modelo.professor p = (modelo.professor)bs.Current;
                controle.ProfessorDB pDb = new controle.ProfessorDB();
                pDb.inserir(p);
                MessageBox.Show("Registro adicionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.MoveLast();
            }
            else
            {
                modelo.professor p = (modelo.professor)bs.Current;
                controle.ProfessorDB pDb = new controle.ProfessorDB();
                pDb.editar(p);
                MessageBox.Show("Registro editado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnAdd.Enabled = true;

            if (bs.Count != 0)
            {
                btnCancel.Enabled = true;
            }
            btnCancel.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            bs.RemoveCurrent();

            if (bs.Count != 0)
            {
                btnDel.Enabled = true;
                habilitarCampos(true);
            }
            else
            {
                btnDel.Enabled = false;
                habilitarCampos(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bs.Count == 0)
            {
                MessageBox.Show("Cadastro Vazio", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controle.ProfessorDB lDb = new controle.ProfessorDB();
            int id = Convert.ToInt16(lbCod.Text);

            if(MessageBox.Show("Remover " + txtNome.Text,
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lDb.excluir(id);
                bs.RemoveCurrent();
                bs.MoveFirst();

                if (bs.Count != 0) bs.MoveFirst();
                else
                {
                    habilitarCampos(false);
                    btnDel.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int idProfessor = Int16.Parse(txtCod.Text);
            var obj = bs.List.OfType<modelo.professor>().ToList().Find(l => l.idprofessor == idProfessor);

            int pos = bs.IndexOf(obj);
            if (pos < 0) MessageBox.Show("Professor não encontrado....");
            else bs.Position = pos;
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void FormProfessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMDI fr = (FormMDI)this.MdiParent;
            fr.frProfessor = null;
        }

        private void inkPesquisar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDialogPesquisarProfessor fr = new FormDialogPesquisarProfessor();
            fr.ShowDialog();

            if (fr.Id != 0)
            {
                var obj = bs.List.OfType<modelo.professor>().ToList().Find(
                    linha => linha.idprofessor == fr.Id
                    );
                int pos = bs.IndexOf(obj);

                bs.Position = pos;
            }
        }
    }
}
