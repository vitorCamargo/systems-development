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
    public partial class FormDialogAutor : Form
    {
        private modelo.autor autor;

        public modelo.autor Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public FormDialogAutor()
        {
            InitializeComponent();
        }

        private void FormDialogAutor_Load(object sender, EventArgs e)
        {
            if (Autor != null)
            {
                txtNome.Text = Autor.nome;
                txtNacionalidade.Text = Autor.nacionalidade;
                txtFone.Text = Autor.telefone;
                txtOcupacao.Text = Autor.ocupacao;
                dtNascimento.Value = Autor.nascimento;
            }
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Autor == null) novo();
            else editar();
            this.Dispose();
        }

        private void novo(){
            controle.AutorDB aDb = new controle.AutorDB();
            Autor = new modelo.autor()
            {
                idAutor = aDb.proximoCodigo(),
                nome = txtNome.Text,
                nacionalidade = txtNacionalidade.Text,
                ocupacao = txtOcupacao.Text,
                telefone = txtFone.Text,
                nascimento = dtNascimento.Value
            };
            aDb.inserir(Autor);
        }

        private void editar()
        {
            controle.AutorDB aDb = new controle.AutorDB();
            Autor.nome = txtNome.Text;
            Autor.nacionalidade = txtNacionalidade.Text;
            Autor.telefone = txtFone.Text;
            Autor.ocupacao = txtOcupacao.Text;
            Autor.nascimento = dtNascimento.Value;
            aDb.editar(Autor);
        }
    }
}
