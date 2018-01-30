using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRevisao
{
    class Carrinho
    {
        private BindingList<Produto> produtos;

        internal BindingList<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        private string cliente;

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Carrinho()
        {
            Produtos = new BindingList<Produto>();
            Cliente = "";
        }

        public void adicionar(Produto p)
        {
            Produtos.Add(p);
        }

        public void remover(Produto p)
        {
            Produtos.Remove(p);
        }

        public string TotalCarrinho
        {
            get {
                return "TOTAL " + String.Format("{0:C2}", produtos.Sum(item => item.PrecoUnitario));
            }
        }
    }
}