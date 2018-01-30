namespace prjBiblioteca.visao
{
    partial class FormMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.loginHostname = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnArquivo
            // 
            this.mnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnArquivoAlunos,
            this.mnArquivoLivros,
            this.mnArquivoProfessores,
            this.mnArquivoSair});
            this.mnArquivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnArquivo.Name = "mnArquivo";
            this.mnArquivo.Size = new System.Drawing.Size(67, 21);
            this.mnArquivo.Text = "Arquivo";
            // 
            // mnArquivoAlunos
            // 
            this.mnArquivoAlunos.Name = "mnArquivoAlunos";
            this.mnArquivoAlunos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnArquivoAlunos.Size = new System.Drawing.Size(186, 22);
            this.mnArquivoAlunos.Text = "Alunos";
            this.mnArquivoAlunos.Click += new System.EventHandler(this.mnArquivoAlunos_Click);
            // 
            // mnArquivoLivros
            // 
            this.mnArquivoLivros.Name = "mnArquivoLivros";
            this.mnArquivoLivros.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnArquivoLivros.Size = new System.Drawing.Size(186, 22);
            this.mnArquivoLivros.Text = "Livros";
            this.mnArquivoLivros.Click += new System.EventHandler(this.mnArquivoLivros_Click);
            // 
            // mnArquivoProfessores
            // 
            this.mnArquivoProfessores.Name = "mnArquivoProfessores";
            this.mnArquivoProfessores.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnArquivoProfessores.Size = new System.Drawing.Size(186, 22);
            this.mnArquivoProfessores.Text = "Professores";
            this.mnArquivoProfessores.Click += new System.EventHandler(this.mnArquivoProfessores_Click);
            // 
            // mnArquivoSair
            // 
            this.mnArquivoSair.Name = "mnArquivoSair";
            this.mnArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnArquivoSair.Size = new System.Drawing.Size(186, 22);
            this.mnArquivoSair.Text = "Sair";
            this.mnArquivoSair.Click += new System.EventHandler(this.mnArquivoSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginUser,
            this.loginHostname});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // loginUser
            // 
            this.loginUser.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(63, 18);
            this.loginUser.Text = "Usuário: ";
            // 
            // loginHostname
            // 
            this.loginHostname.Font = new System.Drawing.Font("Comfortaa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHostname.Name = "loginHostname";
            this.loginHostname.Size = new System.Drawing.Size(78, 18);
            this.loginHostname.Text = "hostname: ";
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "Controle de Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoAlunos;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoProfessores;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loginUser;
        private System.Windows.Forms.ToolStripStatusLabel loginHostname;
        private System.Windows.Forms.ToolStripMenuItem mnArquivoLivros;
    }
}