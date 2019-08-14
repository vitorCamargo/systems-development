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
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            controle.AlunoDB aDb = new controle.AlunoDB();
            aDb.consultar(bs);

            lbRM.DataBindings.Add(new Binding("text", bs, "idaluno"));
            lbAluno.DataBindings.Add(new Binding("text", bs, "nome")); 
            lbFone.DataBindings.Add(new Binding("text", bs, "fone"));
            lbSerie.DataBindings.Add(new Binding("text", bs, "sala"));
            lbCidade.DataBindings.Add(new Binding("text", bs, "cidade"));
            lbNascimento.DataBindings.Add(new Binding("text", bs, "nascimento"));
            lbCurso.DataBindings.Add(new Binding("text", bs, "curso.descricao"));
        }
        
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (bn.PositionItem.Text.Equals("0"))
            {
                MessageBox.Show("Cadastro Vazio", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormDialogAluno fr = new FormDialogAluno();

            modelo.aluno reg = (modelo.aluno)bs.Current;
            controle.AlunoDB aDb = new controle.AlunoDB();
            reg = aDb.procurar(reg);
            fr.Aluno = reg;
            fr.ShowDialog();

            if (fr.Aluno != null)
            {
                aDb.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void FormAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMDI fr = (FormMDI)this.MdiParent;
            fr.frAluno = null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormDialogAluno fr = new FormDialogAluno();

            fr.Bs = bs;
            fr.Aluno = null;
            fr.ShowDialog();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (bn.PositionItem.Text.Equals("0"))
            {
                MessageBox.Show("Cadastro Vazio", "Mensagem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controle.AlunoDB aDB = new controle.AlunoDB();

            if (MessageBox.Show("Remover " + lbAluno.Text,
            "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modelo.aluno reg = (modelo.aluno)bs.Current;
                aDB.excluir(reg);
                bn.BindingSource.RemoveCurrent();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormDialogPesquisarAluno fr = new FormDialogPesquisarAluno();
            fr.ShowDialog();

            if (fr.Id != 0)
            {
                var obj = bs.List.OfType<modelo.aluno>().ToList().Find(
                    linha => linha.idaluno == fr.Id
                    );
                int pos = bs.IndexOf(obj);

                bs.Position = pos;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            controle.AlunoDB aDB = new controle.AlunoDB();
            aDB.imprimir(ds);
            FormRelatorio fr = new FormRelatorio();
            fr.Caminho = "../../relatorio/rAluno.rdlc";
            fr.Ds = ds;
            fr.ShowDialog();
        }
    }
}
