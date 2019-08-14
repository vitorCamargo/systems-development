namespace prjBiblioteca.visao
{
    partial class FormDialogLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPublicacao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.MaskedTextBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbAutor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEditora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.inkExcluirGenero = new System.Windows.Forms.LinkLabel();
            this.inkExcluirAutor = new System.Windows.Forms.LinkLabel();
            this.inkExcluirEditora = new System.Windows.Forms.LinkLabel();
            this.inkEditarGenero = new System.Windows.Forms.LinkLabel();
            this.inkEditarAutor = new System.Windows.Forms.LinkLabel();
            this.inkEditarEditora = new System.Windows.Forms.LinkLabel();
            this.inkNovoGenero = new System.Windows.Forms.LinkLabel();
            this.inkNovoAutor = new System.Windows.Forms.LinkLabel();
            this.inkNovoEditora = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(13, 30);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(214, 21);
            this.txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publicação:";
            // 
            // dtPublicacao
            // 
            this.dtPublicacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPublicacao.Location = new System.Drawing.Point(262, 29);
            this.dtPublicacao.Name = "dtPublicacao";
            this.dtPublicacao.Size = new System.Drawing.Size(176, 21);
            this.dtPublicacao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resumo:";
            // 
            // txtResumo
            // 
            this.txtResumo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumo.Location = new System.Drawing.Point(13, 79);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(214, 52);
            this.txtResumo.TabIndex = 5;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(262, 79);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(176, 21);
            this.txtISBN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISBN:";
            // 
            // btProcurar
            // 
            this.btProcurar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(262, 109);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(175, 65);
            this.btProcurar.TabIndex = 8;
            this.btProcurar.Text = "ISBN";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Páginas:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginas.Location = new System.Drawing.Point(13, 154);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(83, 21);
            this.txtPaginas.TabIndex = 10;
            // 
            // txtEdicao
            // 
            this.txtEdicao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicao.Location = new System.Drawing.Point(108, 154);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(119, 21);
            this.txtEdicao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edição Número:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gênero:";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(13, 206);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(214, 24);
            this.cbGenero.TabIndex = 14;
            // 
            // cbAutor
            // 
            this.cbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutor.FormattingEnabled = true;
            this.cbAutor.Location = new System.Drawing.Point(13, 258);
            this.cbAutor.Name = "cbAutor";
            this.cbAutor.Size = new System.Drawing.Size(214, 24);
            this.cbAutor.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Autor:";
            // 
            // cbEditora
            // 
            this.cbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.Location = new System.Drawing.Point(12, 313);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(214, 24);
            this.cbEditora.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Editora:";
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(262, 296);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(175, 37);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btGravar
            // 
            this.btGravar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.Location = new System.Drawing.Point(262, 253);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(175, 37);
            this.btGravar.TabIndex = 20;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // inkExcluirGenero
            // 
            this.inkExcluirGenero.AutoSize = true;
            this.inkExcluirGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkExcluirGenero.Location = new System.Drawing.Point(179, 189);
            this.inkExcluirGenero.Name = "inkExcluirGenero";
            this.inkExcluirGenero.Size = new System.Drawing.Size(50, 16);
            this.inkExcluirGenero.TabIndex = 21;
            this.inkExcluirGenero.TabStop = true;
            this.inkExcluirGenero.Text = "Excluir...";
            this.inkExcluirGenero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkExcluirGenero_LinkClicked);
            // 
            // inkExcluirAutor
            // 
            this.inkExcluirAutor.AutoSize = true;
            this.inkExcluirAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkExcluirAutor.Location = new System.Drawing.Point(179, 242);
            this.inkExcluirAutor.Name = "inkExcluirAutor";
            this.inkExcluirAutor.Size = new System.Drawing.Size(50, 16);
            this.inkExcluirAutor.TabIndex = 22;
            this.inkExcluirAutor.TabStop = true;
            this.inkExcluirAutor.Text = "Excluir...";
            this.inkExcluirAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkExcluirAutor_LinkClicked);
            // 
            // inkExcluirEditora
            // 
            this.inkExcluirEditora.AutoSize = true;
            this.inkExcluirEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkExcluirEditora.Location = new System.Drawing.Point(180, 297);
            this.inkExcluirEditora.Name = "inkExcluirEditora";
            this.inkExcluirEditora.Size = new System.Drawing.Size(50, 16);
            this.inkExcluirEditora.TabIndex = 23;
            this.inkExcluirEditora.TabStop = true;
            this.inkExcluirEditora.Text = "Excluir...";
            this.inkExcluirEditora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkExcluirEditora_LinkClicked);
            // 
            // inkEditarGenero
            // 
            this.inkEditarGenero.AutoSize = true;
            this.inkEditarGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkEditarGenero.Location = new System.Drawing.Point(126, 189);
            this.inkEditarGenero.Name = "inkEditarGenero";
            this.inkEditarGenero.Size = new System.Drawing.Size(48, 16);
            this.inkEditarGenero.TabIndex = 24;
            this.inkEditarGenero.TabStop = true;
            this.inkEditarGenero.Text = "Editar...";
            this.inkEditarGenero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkEditarGenero_LinkClicked);
            // 
            // inkEditarAutor
            // 
            this.inkEditarAutor.AutoSize = true;
            this.inkEditarAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkEditarAutor.Location = new System.Drawing.Point(126, 242);
            this.inkEditarAutor.Name = "inkEditarAutor";
            this.inkEditarAutor.Size = new System.Drawing.Size(48, 16);
            this.inkEditarAutor.TabIndex = 25;
            this.inkEditarAutor.TabStop = true;
            this.inkEditarAutor.Text = "Editar...";
            this.inkEditarAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkEditarAutor_LinkClicked);
            // 
            // inkEditarEditora
            // 
            this.inkEditarEditora.AutoSize = true;
            this.inkEditarEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkEditarEditora.Location = new System.Drawing.Point(126, 296);
            this.inkEditarEditora.Name = "inkEditarEditora";
            this.inkEditarEditora.Size = new System.Drawing.Size(48, 16);
            this.inkEditarEditora.TabIndex = 26;
            this.inkEditarEditora.TabStop = true;
            this.inkEditarEditora.Text = "Editar...";
            this.inkEditarEditora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkEditarEditora_LinkClicked);
            // 
            // inkNovoGenero
            // 
            this.inkNovoGenero.AutoSize = true;
            this.inkNovoGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkNovoGenero.Location = new System.Drawing.Point(77, 189);
            this.inkNovoGenero.Name = "inkNovoGenero";
            this.inkNovoGenero.Size = new System.Drawing.Size(47, 16);
            this.inkNovoGenero.TabIndex = 27;
            this.inkNovoGenero.TabStop = true;
            this.inkNovoGenero.Text = "Novo...";
            this.inkNovoGenero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkNovoGenero_LinkClicked);
            // 
            // inkNovoAutor
            // 
            this.inkNovoAutor.AutoSize = true;
            this.inkNovoAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkNovoAutor.Location = new System.Drawing.Point(77, 241);
            this.inkNovoAutor.Name = "inkNovoAutor";
            this.inkNovoAutor.Size = new System.Drawing.Size(47, 16);
            this.inkNovoAutor.TabIndex = 28;
            this.inkNovoAutor.TabStop = true;
            this.inkNovoAutor.Text = "Novo...";
            this.inkNovoAutor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkNovoAutor_LinkClicked);
            // 
            // inkNovoEditora
            // 
            this.inkNovoEditora.AutoSize = true;
            this.inkNovoEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkNovoEditora.Location = new System.Drawing.Point(77, 296);
            this.inkNovoEditora.Name = "inkNovoEditora";
            this.inkNovoEditora.Size = new System.Drawing.Size(47, 16);
            this.inkNovoEditora.TabIndex = 29;
            this.inkNovoEditora.TabStop = true;
            this.inkNovoEditora.Text = "Novo...";
            this.inkNovoEditora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inkNovoEditora_LinkClicked);
            // 
            // FormDialogLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 345);
            this.Controls.Add(this.inkNovoEditora);
            this.Controls.Add(this.inkNovoAutor);
            this.Controls.Add(this.inkNovoGenero);
            this.Controls.Add(this.inkEditarEditora);
            this.Controls.Add(this.inkEditarAutor);
            this.Controls.Add(this.inkEditarGenero);
            this.Controls.Add(this.inkExcluirEditora);
            this.Controls.Add(this.inkExcluirAutor);
            this.Controls.Add(this.inkExcluirGenero);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.cbEditora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAutor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdicao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btProcurar);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPublicacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FormDialogLivro";
            this.Text = "Livro";
            this.Load += new System.EventHandler(this.FormDialogLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPublicacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPaginas;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbAutor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEditora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.LinkLabel inkExcluirGenero;
        private System.Windows.Forms.LinkLabel inkExcluirAutor;
        private System.Windows.Forms.LinkLabel inkExcluirEditora;
        private System.Windows.Forms.LinkLabel inkEditarGenero;
        private System.Windows.Forms.LinkLabel inkEditarAutor;
        private System.Windows.Forms.LinkLabel inkEditarEditora;
        private System.Windows.Forms.LinkLabel inkNovoGenero;
        private System.Windows.Forms.LinkLabel inkNovoAutor;
        private System.Windows.Forms.LinkLabel inkNovoEditora;
    }
}