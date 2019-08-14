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
    public partial class FormDialogLivro : Form
    {
        private BindingSource bs;

        public BindingSource Bs
        {
            get { return bs; }
            set { bs = value; }
        }

        private modelo.livro livro;

        public modelo.livro Livro
        {
            get { return livro; }
            set { livro = value; }
        }

        public FormDialogLivro()
        {
            InitializeComponent();
        }

        private void FormDialogLivro_Load(object sender, EventArgs e)
        {
            controle.AutorDB aDb = new controle.AutorDB();
            aDb.listar(cbAutor);

            controle.EditoraDB eDb = new controle.EditoraDB();
            eDb.listar(cbEditora);

            controle.GeneroDB gDb = new controle.GeneroDB();
            gDb.listar(cbGenero);

            if (Livro == null)
            {
                cbGenero.SelectedIndex = 0;
                cbEditora.SelectedIndex = 0;
                cbAutor.SelectedIndex = 0;
            }
            else
            {
                cbEditora.SelectedValue = Livro.idEditora;
                cbGenero.SelectedValue = Livro.idGenero;
                cbAutor.SelectedValue = Livro.idAutor;

                txtTitulo.Text = Livro.titulo;
                txtEdicao.Text = Livro.edicao.ToString();
                txtPaginas.Text = Livro.nrpaginas.ToString();
                txtResumo.Text = Livro.resumo;
                dtPublicacao.Value = Livro.publicacao;
                txtISBN.Text = Livro.codisbn;
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Livro == null)
            {
                novo();
            }
            else
            {
                editar();
            }
            MessageBox.Show("Registro gravado com sucesso!");
            this.Dispose();
        }

        private void novo()
        {
            controle.LivroDB lDb = new controle.LivroDB();
            Livro = new modelo.livro()
            {
                idLivro = lDb.proximoCodigo(),
                idEditora = Convert.ToInt16(cbEditora.SelectedValue),
                idGenero = Convert.ToInt16(cbGenero.SelectedValue),
                idAutor = Convert.ToInt16(cbAutor.SelectedValue),
                titulo = txtTitulo.Text.ToUpper(),
                edicao = Convert.ToInt16(txtEdicao.Text),
                nrpaginas = Convert.ToInt16(txtPaginas.Text),
                resumo = txtResumo.Text.ToUpper(),
                publicacao = dtPublicacao.Value,
                codisbn = txtISBN.Text
            };
            lDb.inserir(Livro);
        }

        private void editar()
        {
            controle.LivroDB lDb = new controle.LivroDB();
            
            Livro.idEditora = Convert.ToInt16(cbEditora.SelectedValue);
            Livro.idGenero = Convert.ToInt16(cbGenero.SelectedValue);
            Livro.idAutor = Convert.ToInt16(cbAutor.SelectedValue);
            Livro.titulo = txtTitulo.Text.ToUpper();
            Livro.edicao = Convert.ToInt16(txtEdicao.Text);
            Livro.nrpaginas = Convert.ToInt16(txtPaginas.Text);
            Livro.resumo = txtResumo.Text.ToUpper();
            Livro.publicacao = dtPublicacao.Value;
            Livro.codisbn = txtISBN.Text;
            lDb.editar(Livro);
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                controle.LivroDB lDb = new controle.LivroDB();
                modelo.livro reg = new modelo.livro();
                lDb.procurarLivroGoogle(txtISBN.Text, reg);

                if (reg == null) return;

                txtTitulo.Text = reg.titulo;
                txtEdicao.Text = reg.edicao.ToString();
                txtPaginas.Text = reg.nrpaginas.ToString();
                txtResumo.Text = reg.resumo;
                dtPublicacao.Value = reg.publicacao;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.Message);
            }
        }

        private void inkNovoAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDialogAutor fr = new FormDialogAutor();
            fr.Autor = null;
            fr.ShowDialog();

            if (fr.Autor != null)
            {
                controle.AutorDB gDb = new controle.AutorDB();
                gDb.listar(cbAutor);
            }
        }

        private void inkExcluirGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controle.GeneroDB eDb = new controle.GeneroDB();
            modelo.genero genero = (modelo.genero)cbGenero.SelectedItem;
            eDb.excluir(genero);
            eDb.listar(cbGenero);
            MessageBox.Show("Genero excluído com sucesso!");
        }

        private void inkEditarGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGenero fr = new FormGenero();
            fr.Genero = (modelo.genero)cbGenero.SelectedItem;
            fr.ShowDialog();

            if (fr.Genero != null)
            {
                controle.GeneroDB gDb = new controle.GeneroDB();
                gDb.listar(cbGenero);
            }
        }

        private void inkEditarAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDialogAutor fr = new FormDialogAutor();
            fr.Autor = (modelo.autor)cbAutor.SelectedItem;
            fr.ShowDialog();

            if (fr.Autor != null)
            {
                controle.AutorDB gDb = new controle.AutorDB();
                gDb.listar(cbAutor);
            }
        }

        private void inkExcluirAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controle.AutorDB eDb = new controle.AutorDB();
            modelo.autor autor = (modelo.autor)cbAutor.SelectedItem;
            eDb.excluir(autor);
            eDb.listar(cbAutor);
            MessageBox.Show("Autor excluído com sucesso!");
        }

        private void inkNovoGenero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGenero fr = new FormGenero();
            fr.Genero = null;
            fr.ShowDialog();

            if (fr.Genero != null)
            {
                controle.GeneroDB gDb = new controle.GeneroDB();
                gDb.listar(cbGenero);
            }
        }

        private void inkNovoEditora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditora fr = new FormEditora();
            fr.Editora = null;
            fr.ShowDialog();

            if (fr.Editora != null)
            {
                controle.EditoraDB eDb = new controle.EditoraDB();
                eDb.listar(cbEditora);
            }
        }

        private void inkEditarEditora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEditora fr = new FormEditora();
            fr.Editora = (modelo.editora)cbEditora.SelectedItem;
            fr.ShowDialog();

            if (fr.Editora != null)
            {
                controle.EditoraDB eDb = new controle.EditoraDB();
                eDb.listar(cbEditora);
            }
        }

        private void inkExcluirEditora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controle.EditoraDB eDb = new controle.EditoraDB();
            modelo.editora editora = (modelo.editora)cbEditora.SelectedItem;
            eDb.excluir(editora);
            eDb.listar(cbEditora);
            MessageBox.Show("Editora excluído com sucesso!");
        }
    }
}
