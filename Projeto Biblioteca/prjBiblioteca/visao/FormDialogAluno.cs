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
    public partial class FormDialogAluno : Form
    {
        private BindingSource bs;

        public BindingSource Bs
        {
            get { return bs; }
            set { bs = value; }
        }

        private modelo.aluno aluno;

        public modelo.aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        public FormDialogAluno()
        {
            InitializeComponent();
        }

        private void FormDialogAluno_Load(object sender, EventArgs e)
        {
            controle.cursoBD cDB = new controle.cursoBD();
            cDB.listar(cbCurso);

            if (Aluno == null) cbCurso.SelectedIndex = 0;
            else
            {
                txtNome.Text = Aluno.nome;
                dtNascimento.Value = Aluno.nascimento;
                txtFone.Text = Aluno.fone;
                txtNumero.Text = Aluno.numero.ToString();
                cbUF.Text = Aluno.uf;
                txtBairro.Text = Aluno.bairro;
                txtEndereco.Text = Aluno.endereco;
                txtCidade.Text = Aluno.cidade;
                txtCEP.Text = Aluno.cep;
                txtEmail.Text = Aluno.email;
                txtSala.Text = Aluno.sala;
                cbCurso.SelectedValue = aluno.idcurso;

            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Aluno == null)
            {
                novo();
            }
            else
            {
                editar();
            }
            this.Dispose();
        }

        private void editar()
        {
            controle.AlunoDB aDB = new controle.AlunoDB();

            Aluno.nome = txtNome.Text;
            Aluno.nascimento = dtNascimento.Value;
            Aluno.fone = txtFone.Text;
            Aluno.numero = Convert.ToInt16(txtNumero.Text);
            Aluno.uf = cbUF.Text;
            Aluno.bairro = txtBairro.Text;
            Aluno.endereco = txtEndereco.Text;
            Aluno.cidade = txtCidade.Text;
            Aluno.cep = txtCEP.Text;
            Aluno.email = txtEmail.Text;
            Aluno.sala = txtSala.Text;
            Aluno.idcurso = Convert.ToInt16(cbCurso.SelectedValue);
            aDB.editar(Aluno);
        }

        private void novo()
        {
            controle.AlunoDB aDB = new controle.AlunoDB();

            Aluno = new modelo.aluno()
            {
                idaluno = aDB.proximoCodigo(),
                nome = txtNome.Text,
                sala = txtSala.Text,
                idcurso = Int16.Parse(cbCurso.SelectedValue.ToString()),
                endereco = txtEndereco.Text,
                numero = Int16.Parse(txtNumero.Text),
                cep = txtCEP.Text,
                cidade = txtCidade.Text,
                bairro = txtBairro.Text,
                fone = txtFone.Text,
                email = txtEmail.Text,
                uf= cbUF.Text,
                nascimento = dtNascimento.Value
            };

            aDB.inserir(Aluno);
            aDB.consultar(Bs);
            bs.ResetBindings(false);
            bs.MoveLast();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Aluno = null;
            this.Dispose();
        }

        private void btAddCurso_Click(object sender, EventArgs e)
        {
            modelo.FormDialogCurso fr = new modelo.FormDialogCurso();
            fr.Curso = null;
            fr.ShowDialog();
            if (fr.Curso != null)
            {
                controle.cursoBD cBD = new controle.cursoBD();
                cBD.listar(cbCurso);
            }
        }

        private void btDelCurso_Click(object sender, EventArgs e)
        {
            controle.cursoBD cDB = new controle.cursoBD();
            if (checarDependencia() == false)
            {
                modelo.curso reg = (modelo.curso)cbCurso.SelectedItem;
                cDB.excluir(reg);
                MessageBox.Show("Curs deletado com Sucesso");
                cDB.listar(cbCurso);
            }
            else
            {
                MessageBox.Show("Curso não pode ser excluido pois está sendo usado");
            }
        }

        private bool checarDependencia()
        {
            controle.AlunoDB aDB = new controle.AlunoDB();
            return aDB.checarCurso(cbCurso.SelectedValue.ToString());
        }

        private void cbCurso_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modelo.FormDialogCurso fr = new modelo.FormDialogCurso();
                fr.Curso = (modelo.curso)cbCurso.SelectedItem;
                controle.cursoBD cDB = new controle.cursoBD();
                fr.ShowDialog();
                if (fr.Curso != null)
                {
                    MessageBox.Show("Nome do curso modificado com sucesso");
                    cDB.listar(cbCurso);
                }
            }
        }

        private void btCEP_Click(object sender, EventArgs e)
        {
            controle.CepDB lista = new controle.CepDB();
            modelo.tend_endereco endereco = lista.consultar(txtCEP.Text);
            if (endereco != null)
            {
                txtEndereco.Text = endereco.endereco.ToUpper();
                txtBairro.Text = endereco.tend_bairro.bairro.ToUpper();
                txtCidade.Text = endereco.tend_cidade.cidade.ToUpper();
                cbUF.Text = endereco.tend_cidade.uf;

                txtNumero.Focus();
            }
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            if (Aluno != null)
            {
                FormMapa fr = new FormMapa();
                fr.Aluno = Aluno;
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("É necessário gravar o registro para abrir a visualização do mapa");
            }
        }
    }
}
