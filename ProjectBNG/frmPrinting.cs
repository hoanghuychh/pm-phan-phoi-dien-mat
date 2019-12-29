﻿using ProjectBNG.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ProjectBNG
{
    public partial class frmPrinting : Form
    {
        public frmPrinting()
        {
            InitializeComponent();
        }

        private void frmPrinting_Load(object sender, EventArgs e)
        {
            // cbxPrivateFile
            cbxPrivateFile.Items.Add("Mật");
            cbxPrivateFile.Items.Add("TM");
            cbxPrivateFile.Items.Add("Tuyệt mật");
            cbxPrivateFile.SelectedItem = cbxPrivateFile.Items[0];

            // cbxPrivateAttachedFile
            cbxPrivateAttachedFile.Items.Add("Rõ");
            cbxPrivateAttachedFile.Items.Add("Mật");
            cbxPrivateAttachedFile.Items.Add("TM");
            cbxPrivateAttachedFile.Items.Add("Tuyệt mật");
            cbxPrivateAttachedFile.SelectedItem = cbxPrivateAttachedFile.Items[1];

            // cbxPlaceOfSending: Lay tu DB ra
            cbxPlaceOfSending.Items.Add("Place 0");
            cbxPlaceOfSending.Items.Add("Place 1");
           cbxPlaceOfSending.SelectedItem = cbxPlaceOfSending.Items[0];

            // cbxCensor: Lay tu DB ra
            cbxCensor.Items.Add("Đặng Bảo Châu");
            cbxCensor.Items.Add("Censor 1");
            cbxCensor.Items.Add("Censor 2");
            
            // cbxSigner: Lay tu DB ra
            cbxSigner.Items.Add("Lê Thanh Tùng");
            cbxSigner.Items.Add("Signer 1");
            cbxSigner.Items.Add("Signer 2");

            // chbIncluding, txtIncluding
            chbIncluding.Checked = true;
            txtIncluding.Text = "(Ghi)";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string filePath;
            openFileDialog.Filter = "PDF Files(*.PDF)|*.PDF|All Files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName.ToString();

                string strText = string.Empty;
                try
                {
                    PdfReader reader = new PdfReader(filePath);
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                        String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                        s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                        strText = strText + s;
                        rtxtPdfView.Text = strText;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddAttachedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "(Docx file)|*.docx|(PDF file)|*.pdf" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] parts = openFileDialog.FileName.Trim().Split('\\');
                txtAttachedFileName.Text += parts[parts.Length - 1] + "; ";
            }
        }

        private void btnRemoveAttachedFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAttachedFileName.Text))
            {
                return;
            }

            string[] parts = txtAttachedFileName.Text.Trim().Split(' ');
            int count = parts.Length;
            count--;
            txtAttachedFileName.Text = "";
            for(int i = 0; i < count; i++)
            {
                txtAttachedFileName.Text += parts[i];
            }
        }

        private void txt_Click(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox == null) return;
            if (textBox.Equals(txtIncluding))
            {
                txtIncluding.Text = "";
            }
            if (textBox.Equals(txtPage))
            {
                txtPage.Text = "";
            }
            if (textBox.Equals(txtAllignBottomSignature))
            {
                txtAllignBottomSignature.Text = "";
            }
            if (textBox.Equals(txtAllignBottomSM))
            {
                txtAllignBottomSM.Text = "";
            }
            if (textBox.Equals(txtAllignBottomIncludedSM))
            {
                txtAllignBottomIncludedSM.Text = "";
            }
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || // Alphabe char
                 char.IsSymbol(e.KeyChar) || //Special char
                 char.IsWhiteSpace(e.KeyChar) || //Space
                 char.IsPunctuation(e.KeyChar)) //dot symbol               
            {
                e.Handled = true; // Khong cho nhap so
                MessageBox.Show("Vui lòng nhập số.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void chbPrint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAllignBottomIncludedSM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
