using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String nomeImagem;

  

        PictureBox[,] picbox = new PictureBox[5, 5];
        int[,] m = new int[5, 5];
        Random rand = new Random();

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int col = 1; col < 5; col++)
                for (int lin = 1; lin < 5; lin++)
                {
                    m[col, lin] = rand.Next(1, 15);
                }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (int elemento in m)
            {
                int num = rand.Next(1, 5);
                num += elemento;
                listBox1.Items.Add(num);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int col = 1; col < 5; col++)
                for (int lin = 1; lin < 5; lin++)
                {
                    picbox[col, lin] = new PictureBox();
                    picbox[col, lin].Parent = this;
                    picbox[col, lin].Width = 200;
                    picbox[col, lin].Height = 200;
                    picbox[col, lin].Left = 30 + col * 195;
                    picbox[col, lin].Top = -171 + lin * 195;
                    picbox[col, lin].BorderStyle = BorderStyle.None;
                    picbox[col, lin].SizeMode = PictureBoxSizeMode.StretchImage;

                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int col = 1; col < 5; col++)
                for (int lin = 1; lin < 5; lin++)
                {
                    nomeImagem = "img"+ m[col, lin].ToString() + ".jpg";

                    picbox[col, lin].Load(nomeImagem);
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
