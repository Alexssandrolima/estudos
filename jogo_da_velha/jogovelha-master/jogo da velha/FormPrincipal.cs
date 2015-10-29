using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        int jogador1 = 0, jogador2 = 0;
        string jodadorNome1, jogadorNome2;

        int vezes = 0;
        int i = -1;

        int pc;
        int computador = 0;

        //alex adicionou isto aqui para pegar informações de quem ganhou ou perdeu.

        int a1 = 0, b1 = 0, c1 = 0;
        int d1 = 0, e1 = 0, f1 = 0;
        int g1 = 0, h1 = 0, i1 = 0;

        int a2 = 0, b2 = 0, c2 = 0;
        int d2 = 0, e2 = 0, f2 = 0;
        int g2 = 0, h2 = 0, i2 = 0;

        int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0;


        public void func_aleatorio()
        {
            Random aleatorio = new Random();
            pc = aleatorio.Next(1,10);
        }

        public void condicao()
        {
            if (pc == 1)
            {
                p1++;
            }
            if (pc == 2)
            {
                p2++;
            }
            if (pc == 3)
            {
                p3++;
            }
            if (pc == 4)
            {
                p4++;
            }
            if (pc == 5)
            {
                p5++;
            }
            if (pc == 6)
            {
                p6++;
            }

            if (pc == 7)
            {
                p7++;
            }
            if (pc == 8)
            {
                p8++;
            }
            if (pc == 9)
            {
                p9++;
            }
        }



        private void pictureBox_Click(object sender, EventArgs e)
        {
            //Button butMensagem = sender as Button;
            //PictureBox pictureBox = sender as PictureBox;

            ClsQuemEstaJogando jogando = new ClsQuemEstaJogando();

            jogando.Nomedaimagem = sender as PictureBox;
            jogando.Escolherimagem = escolherimagem;


            retornojogando = clsJogando.PegarNomeImagem(jogando);
            jogando.Nomedaimagem.Image = jogando.Escolherimagem;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {


            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    a1++;
                    jogador1++;
                    pictureBox1.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    a2++;
                    jogador2++;
                    pictureBox1.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                a1++;
                jogador1++;
                pictureBox1.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox1.Enabled = false;

                func_aleatorio();

                while (pc == 1 || p1>=1 || p2>=1 || p3>=1 || p4>=1 || p5>=1 || p6>=1 || p7>=1 || p8>=1 || p9>=1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p1++;
                        condicao();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    b1++;
                    jogador1++;
                    pictureBox2.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    b2++;
                    jogador2++;
                    pictureBox2.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                b1++;
                jogador1++;
                pictureBox2.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox2.Enabled = false;
                func_aleatorio();
                
                while (pc == 2 || p1>=1 || p2>=1 || p3>=1 || p4>=1 || p5>=1 || p6>=1 || p7>=1 || p8>=1 || p9>=1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p2++;
                        condicao();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    c1++;
                    jogador1++;
                    pictureBox3.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    c2++;
                    jogador2++;
                    pictureBox3.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                c1++;
                jogador1++;
                pictureBox3.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox3.Enabled = false;
                func_aleatorio();

                while (pc == 3 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p3++;
                        condicao();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    d1++;
                    jogador1++;
                    pictureBox4.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    d2++;
                    jogador2++;
                    pictureBox4.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                d1++;
                jogador1++;
                pictureBox4.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox4.Enabled = false;
                func_aleatorio();

                while (pc == 4 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p4++;
                        condicao();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    e1++;
                    jogador1++;
                    pictureBox5.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    e2++;
                    jogador2++;
                    pictureBox5.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                e1++;
                jogador1++;
                pictureBox5.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox5.Enabled = false;

                func_aleatorio();

                while (pc == 5 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p5++;
                        condicao();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    f1++;
                    jogador1++;
                    pictureBox6.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    f2++;
                    jogador2++;
                    pictureBox6.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                f1++;
                jogador1++;
                pictureBox6.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox6.Enabled = false;

                func_aleatorio();

                while (pc == 5 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p6++;
                        condicao();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    g1++;
                    jogador1++;
                    pictureBox7.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    g2++;
                    jogador2++;
                    pictureBox7.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                g1++;
                jogador1++;
                pictureBox7.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox7.Enabled = false;

                func_aleatorio();

                while (pc == 6 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p7++;
                        condicao();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    h1++;
                    jogador1++;
                    pictureBox8.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    h2++;
                    jogador2++;
                    pictureBox8.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                h1++;
                jogador1++;
                pictureBox8.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox8.Enabled = false;

                func_aleatorio();

                while (pc == 7 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p8++;
                        condicao();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            vezes++;
            i++;
            if (computador == 0)
            {
                if ((i % 2) == 0)
                {
                    i1++;
                    jogador1++;
                    pictureBox9.Image = Properties.Resources.zero;
                    verifica_jogador1();
                    empate();
                }
                else
                {
                    i2++;
                    jogador2++;
                    pictureBox9.Image = Properties.Resources.x;
                    verifica_jogador2();
                    empate();
                }
            }
            else
            {
                i1++;
                jogador1++;
                pictureBox9.Image = Properties.Resources.zero;
                verifica_jogador1();
                empate();
                pictureBox9.Enabled = false;

                func_aleatorio();

                while (pc == 9 || p1 >= 1 || p2 >= 1 || p3 >= 1 || p4 >= 1 || p5 >= 1 || p6 >= 1 || p7 >= 1 || p8 >= 1 || p9 >= 1)
                {
                    func_aleatorio();
                    MessageBox.Show(pc.ToString());
                }
                switch (pc)
                {
                    case 1: pictureBox1.Image = Properties.Resources.x; break;
                    case 2: pictureBox2.Image = Properties.Resources.x; break;
                    case 3: pictureBox3.Image = Properties.Resources.x; break;
                    case 4: pictureBox4.Image = Properties.Resources.x; break;
                    case 5: pictureBox5.Image = Properties.Resources.x; break;
                    case 6: pictureBox6.Image = Properties.Resources.x; break;
                    case 7: pictureBox7.Image = Properties.Resources.x; break;
                    case 8: pictureBox8.Image = Properties.Resources.x; break;
                    case 9: pictureBox9.Image = Properties.Resources.x; break;
                        verifica_jogador2();
                        p9++;
                        condicao();
                }
            }
        }
        
        public void empate()
        {
            if (vezes == 9)
            {
                MessageBox.Show("Jogo Empatado");
                zerar();

            }
        }

        public void verifica_jogador1()
        {
            if (a1 == 1 && b1 == 1 && c1 == 1
                 || d1 == 1 && e1 == 1 && f1 == 1
                 || g1 == 1 && h1 == 1 && i1 == 1
                 || a1 == 1 && d1 == 1 && g1 == 1
                 || b1 == 1 && e1 == 1 && h1 == 1
                 || c1 == 1 && f1 == 1 && i1 == 1
                 || a1 == 1 && e1 == 1 && i1 == 1
                 || c1 == 1 && e1 == 1 && g1 == 1)
            {
                MessageBox.Show("Jogador O ganhou");
                zerar();
            }
        }

        public void verifica_jogador2()
        {
            if (a2 == 1 && b2 == 1 && c2 == 1
                 || d2 == 1 && e2 == 1 && f2 == 1
                 || g2 == 1 && h2 == 1 && i2 == 1
                 || a2 == 1 && d2 == 1 && g2 == 1
                 || b2 == 1 && e2 == 1 && h2 == 1
                 || c2 == 1 && f2 == 1 && i2 == 1
                 || a2 == 1 && e2 == 1 && i2 == 1
                 || c2 == 1 && e2 == 1 && g2 == 1)
            {
                MessageBox.Show("Jogador X ganhou");
                zerar();
            }
        }


        public void button10_Click(object sender, EventArgs e)
        {
            zerar();
        }
        public void zerar()
        {
            pictureBox1.Image = Properties.Resources.volta;
            pictureBox2.Image = Properties.Resources.volta;
            pictureBox3.Image = Properties.Resources.volta;
            pictureBox4.Image = Properties.Resources.volta;
            pictureBox5.Image = Properties.Resources.volta;
            pictureBox6.Image = Properties.Resources.volta;
            pictureBox7.Image = Properties.Resources.volta;
            pictureBox8.Image = Properties.Resources.volta;
            pictureBox9.Image = Properties.Resources.volta;

            jogador1 = 0;
            jogador2 = 0;
            vezes = 0;
            i = -1;
            computador = 0;

            a1 = 0; b1 = 0; c1 = 0;
            d1 = 0; e1 = 0; f1 = 0;
            g1 = 0; h1 = 0; i1 = 0;

            a2 = 0; b2 = 0; c2 = 0;
            d2 = 0; e2 = 0; f2 = 0;
            g2 = 0; h2 = 0; i2 = 0;

            p1 = 0; p2 = 0; p3 = 0; p4 = 0; p5 = 0; p6 = 0; p7 = 0; p8 = 0; p9 = 0;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void radioButton0_CheckedChanged(object sender, EventArgs e)
        {
            radioButton0.Enabled = false;
            radioButtonX.Enabled = true;
            escolherimagem = Properties.Resources.zero;
        }

        public void radioButtonX_CheckedChanged(object sender, EventArgs e)
        {
            i++;
            radioButtonX.Enabled = false;
            radioButton0.Enabled = true;
            escolherimagem = Properties.Resources.x;
        }

        private void radioButtonComputador_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonX.Enabled = false;
            radioButton0.Enabled = false;
            computador = 10;
            func_aleatorio();
        }


        public object retornojogando { get; set; }

        public Bitmap escolherimagem { get; set; }
    }
}