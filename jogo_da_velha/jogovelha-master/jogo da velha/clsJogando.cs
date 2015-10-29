using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jogo_da_velha
{
    class clsJogando
    {

        internal static void PegarNomeImagem()
        {
            MessageBox.Show(" pegou \n");
        }


        internal static void PegarNomeImagem(string p)
        {
            MessageBox.Show(" pegou \n" + p);
        }

        internal static object PegarNomeImagem(ClsQuemEstaJogando jogando)
        {
            vezes++;
            i++;
            j++;
                if ((i % 2) == 0)
                {
                    jogando.Numbers1[i] = i;
                    jogando.Jogador1 = j;
                    jogando.Nomedaimagem.Image = Properties.Resources.zero;
                    //verifica_jogador1();
                    //empate();
                }
                else
                {
                    jogando.Numbers2[i] = i;
                    jogando.Jogador2 = j;
                    jogando.Nomedaimagem.Image = Properties.Resources.x;
                    //verifica_jogador2();
                    //empate();
                }

            MessageBox.Show(" pegou "

                    + "\n" + jogando.Nomedaimagem.Name
                    + "\n " + jogando.Escolherimagem.Tag
                    + "\n n1" + jogando.Numbers1[i]
                    + "\n n2" + jogando.Numbers2[i]
                    + "\n j1" + jogando.Jogador1
                    + "\n j2" + jogando.Jogador2
                     );


            return jogando;
        }

        public static int vezes { get; set; }

        public static int i { get; set; }

        public static int j { get; set; }
    }
}
