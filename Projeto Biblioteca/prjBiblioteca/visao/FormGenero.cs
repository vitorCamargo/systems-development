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
    public partial class FormGenero : Form
    {

        private modelo.genero genero;

        public modelo.genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public FormGenero()
        {
            InitializeComponent();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (Genero == null) novo();
            else editar();
            this.Dispose();
        }

        private void novo()
        {
            controle.GeneroDB gDb = new controle.GeneroDB();
            Genero = new modelo.genero()
            {
                idGenero = gDb.proximoCodigo(),
                descricao = txtDescricao.Text
            };
            gDb.inserir(Genero);
        }

        private void editar()
        {
            controle.GeneroDB gDb = new controle.GeneroDB();
            Genero.descricao = txtDescricao.Text;
            gDb.editar(Genero);
        }
    }
}
