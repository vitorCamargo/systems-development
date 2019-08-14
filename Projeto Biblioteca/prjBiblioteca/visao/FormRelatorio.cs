using Microsoft.Reporting.WinForms;
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
    public partial class FormRelatorio : Form
    {
        private string caminho;

        public string Caminho
        {
            get { return caminho; }
            set { caminho = value; }
        }

        private DataSet ds;

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = null;

                this.reportViewer1.LocalReport.ReportPath = @caminho;

                source = new ReportDataSource(ds.DataSetName, ds.Tables[0]);

                this.reportViewer1.LocalReport.DataSources.Add(source);
                this.reportViewer1.DocumentMapCollapsed = false;

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }
        }
    }
}
