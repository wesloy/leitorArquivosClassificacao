
using iTextSharp.text.pdf.parser;
using System;
using System.Text;
using System.Windows.Forms;

namespace leitorArquivosClassificacao {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnProcurar_Click(object sender, EventArgs e) {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = false;
            this.ofd1.Title = "Selecionar PDF";
            ofd1.InitialDirectory = @"C:\dados";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Files (*.PDF)|*.PDF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = false;

            DialogResult dr = this.ofd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                txtCaminoNomePDF.Text = ofd1.FileName;
            }
        }

        private void btnConverterPDF_Click(object sender, EventArgs e) {

            
            iTextSharp.text.pdf.PdfReader leitor = new iTextSharp.text.pdf.PdfReader(txtCaminoNomePDF.Text);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <=  leitor.NumberOfPages; i++) {

                sb.Append(PdfTextExtractor.GetTextFromPage(leitor, i));

            }

            rTxt_texto.Text = sb.ToString();
            leitor.Close();

        }




    }
}

