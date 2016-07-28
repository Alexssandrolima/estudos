using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace FormListExtraindoTxt
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public FormPrincipal(string arquivoLocalTexto)
        {
            this._arquivoLocalTexto = arquivoLocalTexto;
            InitializeComponent();
        }

        private readonly string _patchLocal = Environment.CurrentDirectory;

        private const string DirLocal = @"\Dados\";
        private string _arquivoLocalTexto = "alex_fpopular.txt";


        private void btnBuscarTxt_Click(object sender, EventArgs e)
        {

            MetodoBuscarArquivo();
        }

        private void MetodoBuscarArquivo()
        {

            string dirGlobal = _patchLocal + DirLocal;
            string arquivoGlobal = _patchLocal + DirLocal + _arquivoLocalTexto;

            bool existDirGlobal = Directory.Exists(dirGlobal);

            if (existDirGlobal)
            {
                //MessageBox.Show(@"Pasta Local: " + dirGlobal);
                bool existArquivoGlobal = File.Exists(arquivoGlobal);
                if (existArquivoGlobal)
                {
                    //MessageBox.Show(@"Arquivo Local: " + arquivoGlobal);

                    MetodoParaLerLinhaArquivo(arquivoGlobal);

                }
                else
                {
                    MessageBox.Show(@"Arquivo não existe no Local: " + arquivoGlobal);

                }
            }
            else
            {
                MessageBox.Show(@"Não existe o Local: " + dirGlobal);
            }

        }

        //private string arquivo;
        private string mensagem;
        private void MetodoParaLerLinhaArquivo(string arquivoGlobal)
        {
            List<string> mensagemLinha = new List<string>(); 
            //using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            //{ 
            //    openFileDialog.Title = "xxxxxxxxxo";
            //    openFileDialog.InitialDirectory = arquivoGlobal; 
            //    //Se ja quiser em abrir em um diretorio especifico 
            //    openFileDialog.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"; 
            //    openFileDialog.FilterIndex = 2; 
            //    openFileDialog.RestoreDirectory = true; 
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)  arquivo = openFileDialog.FileName; 
            //}
            if (String.IsNullOrEmpty(arquivoGlobal))
            {
                MessageBox.Show(@"Arquivo Invalido", @"Salvar Como", MessageBoxButtons.OK);
            } 
            else 
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Usuário");
                dt.Columns.Add("Senha");
                //dt.Columns.Add("Nome1");
                //dt.Columns.Add("Nome2");


                using (StreamReader texto = new StreamReader(arquivoGlobal))
                {
                    while ((mensagem = texto.ReadLine()) != null)
                    {
                        string[] split = mensagem.Split(new Char[] { '#' });

                        mensagemLinha.Add(mensagem);
                        dt.Rows.Add(split[1], split[2]);
                    }
                } 
                int registro = mensagemLinha.Count; //total de linhas do arquivo.

                //DataGridViewColumn column = dGVArquivoTexto.Columns[0];
                //column.Width = 60;

                //dGVArquivoTexto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
                //dGVArquivoTexto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dGVArquivoTexto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                //dGVArquivoTexto.Columns.Add(column);
  
                dGVArquivoTexto.DataSource = dt;

                //for (int i = 0; i < mensagemLinha.Count; i++)
                //{
                //    TextBox textbox1 = new TextBox(); 
                //    textbox1.Text += mensagemLinha[i]; 
                //    //File.WriteAllText(arquivo, mensagemLinha[i]);
                //} 
            } 
        }

        private void dGVArquivoTexto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVArquivoTexto.Rows.Count > 0)
            {
                try
                {
                    if (e.RowIndex < 0)
                    {
                        //  MessageBox.Show(e.RowIndex + " \n " +e.ColumnIndex);
                    }
                    else
                    {
                        txtUsuario.Text = Convert.ToString(dGVArquivoTexto.Rows[e.RowIndex].Cells[0].Value);
                        txtSenha.Text = Convert.ToString(dGVArquivoTexto.Rows[e.RowIndex].Cells[1].Value);
                    }
                }

                catch (Exception cell)
                {
                    MessageBox.Show(
                    cell.StackTrace + @" \n " +
                    cell.InnerException + @" \n " +
                    cell.Data + @" \n " +
                    cell.TargetSite + @"<- \n " + dGVArquivoTexto.Rows.Count + @" \n  " + cell.Message, @"Error ao Selecionar a Celula");
                }
            }
        }


        private void dGVArquivoTexto_SelectionChanged(object sender, EventArgs e)
        {
            if (dGVArquivoTexto.SelectedRows.Count > 0)
            {
                //codigo, nome, nivelacesso
                try
                {
                    txtUsuario.Text = Convert.ToString(dGVArquivoTexto.Rows[dGVArquivoTexto.SelectedRows[0].Index].Cells[0].Value);
                    txtSenha.Text = Convert.ToString(dGVArquivoTexto.Rows[dGVArquivoTexto.SelectedRows[0].Index].Cells[1].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + @"\n Ocorreu um Error ");
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcessarSite_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text))
            {
                FormSiteFpopular abrirsite = new FormSiteFpopular(txtUsuario.Text, txtSenha.Text);
                abrirsite.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MetodoBuscarArquivo();
        }
    }
}
