namespace leitorArquivosClassificacao {
    partial class frmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCaminoNomePDF = new System.Windows.Forms.TextBox();
            this.btnConverterPDF = new System.Windows.Forms.Button();
            this.rTxt_texto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(501, 22);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCaminoNomePDF
            // 
            this.txtCaminoNomePDF.Location = new System.Drawing.Point(23, 24);
            this.txtCaminoNomePDF.Name = "txtCaminoNomePDF";
            this.txtCaminoNomePDF.Size = new System.Drawing.Size(472, 20);
            this.txtCaminoNomePDF.TabIndex = 1;
            // 
            // btnConverterPDF
            // 
            this.btnConverterPDF.Location = new System.Drawing.Point(23, 71);
            this.btnConverterPDF.Name = "btnConverterPDF";
            this.btnConverterPDF.Size = new System.Drawing.Size(75, 23);
            this.btnConverterPDF.TabIndex = 2;
            this.btnConverterPDF.Text = "Ler PDF";
            this.btnConverterPDF.UseVisualStyleBackColor = true;
            this.btnConverterPDF.Click += new System.EventHandler(this.btnConverterPDF_Click);
            // 
            // rTxt_texto
            // 
            this.rTxt_texto.Location = new System.Drawing.Point(23, 100);
            this.rTxt_texto.Name = "rTxt_texto";
            this.rTxt_texto.Size = new System.Drawing.Size(553, 337);
            this.rTxt_texto.TabIndex = 3;
            this.rTxt_texto.Text = "";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 449);
            this.Controls.Add(this.rTxt_texto);
            this.Controls.Add(this.btnConverterPDF);
            this.Controls.Add(this.txtCaminoNomePDF);
            this.Controls.Add(this.btnProcurar);
            this.Name = "frmPrincipal";
            this.Text = ".: Principal :.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCaminoNomePDF;
        private System.Windows.Forms.Button btnConverterPDF;
        private System.Windows.Forms.RichTextBox rTxt_texto;
    }
}

