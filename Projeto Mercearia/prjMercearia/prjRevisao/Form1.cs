using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRevisao
{
    public partial class Form1 : Form
    {
        Carrinho carrinho = new Carrinho();

        BindingList<Produto> lista = new BindingList<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            preencherLista();

            listaProdutos.DataSource = lista;
            listaProdutos.DisplayMember = "nome";
            listaProdutos.ValueMember = "codigo";

            bs.DataSource = carrinho.Produtos;
            dgLista.DataSource = bs;

            lbPrecoTotal.Text = carrinho.TotalCarrinho;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int cod = Int16.Parse(listaProdutos.SelectedValue.ToString());

            Produto p = (from item in lista
                         where item.Codigo == cod
                         select item).FirstOrDefault();

            if (p != null) {
                carrinho.adicionar(p);
                bs.ResetBindings(false);
            } else {
                MessageBox.Show("Produto não cadastrado");
            }
            lbPrecoTotal.Text = carrinho.TotalCarrinho;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bs.Count == 0) {
                return;
            }

            Produto atual = (Produto) bs.Current;

            Produto p = (from item in lista
                         where item.Codigo == atual.Codigo
                         select item).FirstOrDefault();

            if (p != null) {
                carrinho.remover(p);
                bs.ResetBindings(false);
            }
            lbPrecoTotal.Text = carrinho.TotalCarrinho;
        }

        private void preencherLista()
        {
            System.IO.StreamReader arquivo = new System.IO.StreamReader(@"../../../produtos.txt");

            while (arquivo.Peek() >= 0) {
                string linha = arquivo.ReadLine();
                string[] campos = linha.Split(';');
                Produto p = new Produto(Int16.Parse(campos[0]),
                                        campos[1],
                                        Double.Parse(campos[2])
                    );
                lista.Add(p);
            }
            arquivo.Close();
        }
    }
}