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
    public partial class FormLivro : Form
    {
        public FormLivro()
        {
            InitializeComponent();
        }

        private void FormLivro_Load(object sender, EventArgs e)
        {
            controle.LivroDB aDb = new controle.LivroDB();
            aDb.consultar(bs);

            lbCod.DataBindings.Add(new Binding("text", bs, "idLivro"));
            lbTitulo.DataBindings.Add(new Binding("text", bs, "titulo"));
            lbAutor.DataBindings.Add(new Binding("text", bs, "autor.nome"));
            lbGenero.DataBindings.Add(new Binding("text", bs, "genero.descricao"));
            lbEditora.DataBindings.Add(new Binding("text", bs, "editora.descricao"));
            lbPublicacao.DataBindings.Add(new Binding("text", bs, "publicacao"));
            lbISBN.DataBindings.Add(new Binding("text", bs, "codisbn"));
        }

        private void FormLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMDI fr = (FormMDI)this.MdiParent;
            fr.frLivro = null;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormDialogLivro fr = new FormDialogLivro();
            fr.Livro = null;
            fr.Bs = bs;
            fr.ShowDialog();

            if (fr.Livro != null)
            {
                bs.ResetBindings(false);
                controle.LivroDB lDb = new controle.LivroDB();
                lDb.consultar(bs);
                bs.MoveLast();
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (bn.PositionItem.Text.Equals("0"))
            {
                MessageBox.Show("Cadastro Vazio", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormDialogLivro fr = new FormDialogLivro();
            modelo.livro reg = (modelo.livro)bs.Current;
            controle.LivroDB lDb = new controle.LivroDB();
            lDb.procurar(reg);
            fr.Livro = reg;
            fr.ShowDialog();

            if (fr.Livro != null)
            {
                lDb.consultar(bs);
                bs.ResetBindings(false);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (bn.PositionItem.Text.Equals("0"))
            {
                MessageBox.Show("Cadastro Vazio", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controle.LivroDB aDb = new controle.LivroDB();
            if (MessageBox.Show("Remover " + lbAutor.Text, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modelo.livro reg = (modelo.livro)bs.Current;
                aDb.excluir(reg);
                bn.BindingSource.RemoveCurrent();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormDialogPesquisarLivro fr = new FormDialogPesquisarLivro();
            fr.ShowDialog();

            if (fr.Id != 0)
            {
                var obj = bs.List.OfType<modelo.livro>().ToList().Find(
                    linha => linha.idLivro == fr.Id
                    );
                int pos = bs.IndexOf(obj);

                bs.Position = pos;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            controle.LivroDB lDB = new controle.LivroDB();
            lDB.imprimir(ds);
            FormRelatorio fr = new FormRelatorio();
            fr.Caminho = "../../relatorio/rLivro.rdlc";
            fr.Ds = ds;
            fr.ShowDialog();
        }

    }
}
