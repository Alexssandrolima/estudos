using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImprimindoTextoDiretoImpressora
{
    public partial class FormImpressao : Form
    {
        public FormImpressao()
        {
            InitializeComponent();
            CarregarListaDeImpressoras();
        }

        private void CarregarListaDeImpressoras()
        {
            comboBoxImpressoras.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBoxImpressoras.Items.Add(printer);
            }
        }

        private void FormImpressao_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;  //tirar as bordas.
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            //this.ControlBox = false;



        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            //using (var printDocument = new System.Drawing.Printing.PrintDocument())
            //{
            //    printDocument.PrintPage += printDocument_PrintPage;
            //    printDocument.PrinterSettings.PrinterName = comboBoxImpressoras.SelectedItem.ToString();
            //    printDocument.Print();
            //}


            using (var printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.PrinterSettings.PrinterName = comboBoxImpressoras.SelectedItem.ToString();
                _texto = textBoxImpressao.Text;
                printDocument.Print();
            }

        }

        //imprimir texto
        //void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    var printDocument = sender as System.Drawing.Printing.PrintDocument;

        //    if (printDocument != null)
        //    {
        //        e.Graphics.DrawImage(Image.FromFile("logo.png"), new Point(5, 5));
        //    }
        //}



        //void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    var printDocument = sender as System.Drawing.Printing.PrintDocument;

        //    if (printDocument != null)
        //    {
        //        using (var font = new Font("Times New Roman", 14))
        //        using (var brush = new SolidBrush(Color.Black))
        //        {
        //            e.Graphics.DrawString(
        //                textBoxImpressao.Text,
        //                font,
        //                brush,
        //                new RectangleF(0, 0, printDocument.DefaultPageSettings.PrintableArea.Width, printDocument.DefaultPageSettings.PrintableArea.Height));
        //        }
        //    }
        //}


        void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var printDocument = sender as System.Drawing.Printing.PrintDocument;

            if (printDocument != null)
            {
                using (var fonte = new Font("Times New Roman", 14))
                using (var brush = new SolidBrush(Color.Black))
                {
                    int caracteresNaPagina = 0;
                    int linhasPorPagina = 0;

                    e.Graphics.MeasureString(
                        _texto, fonte, e.MarginBounds.Size, StringFormat.GenericTypographic,
                        out caracteresNaPagina, out linhasPorPagina);

                    e.Graphics.DrawString(
                        _texto.Substring(0, caracteresNaPagina),
                        fonte,
                        brush,
                        e.MarginBounds);

                    _texto = _texto.Substring(caracteresNaPagina);

                    e.HasMorePages = _texto.Length > 0;
                }
            }
        }


        public string _texto { get; set; }
    }
}
