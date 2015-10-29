using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//trabalhando com imagens
using System.Drawing;
using System.Windows.Forms;


namespace jogo_da_velha
{
    class ClsQuemEstaJogando
    {

        private PictureBox nomedaimagem;

        public PictureBox Nomedaimagem
        {
            get { return nomedaimagem; }
            set { nomedaimagem = value; }
        }

        private Bitmap escolherimagem;

        public Bitmap Escolherimagem
        {
            get { return escolherimagem; }
            set { escolherimagem = value; }
        }
        private int[] numbers1 = new int[5];

        public int[] Numbers1
        {
            get { return numbers1; }
            set { numbers1 = value; }
        }

        private int[] numbers2 = new int[5];

        public int[] Numbers2
        {
            get { return numbers2; }
            set { numbers2 = value; }
        }

        private int jogador1;

        public int Jogador1
        {
            get { return jogador1; }
            set { jogador1 = value; }
        }

        private int jogador2;

        public int Jogador2
        {
            get { return jogador2; }
            set { jogador2 = value; }
        }


    }
}
