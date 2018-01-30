using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRevisao
{
    class Produto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double precoUnitario;

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public Produto(int codigo, string nome, double precoUnitario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.precoUnitario = precoUnitario;
        }
    }
}