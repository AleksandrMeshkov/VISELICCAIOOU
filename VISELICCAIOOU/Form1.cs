using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VISELICCAIOOU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public string text;
        public char[] word;
        public int hp;
        public int hptrue;
        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            hp = 0;
            label1.Text = null;
            textBox1.Text = null;
            word = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += '.';
                word[i] = '.';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool words = false;
            int j = 0;
            if (textBox2.Text.Length == 1)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (textBox2.Text[0] == text[i])
                    {
                        words = true;
                        hptrue++;
                        word[i] = text[i];
                        label1.Text = null;
                    }
                }
                if (words == true)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += word[i];
                    }
                    if (hptrue == text.Length)
                    {
                        MessageBox.Show("Ты победил!");
                    }
                }
                else
                {
                    hp++;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (hp == 5)
                    {
                        MessageBox.Show("Ты проиграл!");
                        label1.Text = null;
                        label1.Text = text;
                    }
                }

            }
            else if (textBox2.Text.Length > 1)
            {
                if (textBox2.Text == text)
                {
                    label1.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += text[i];
                    }
                    MessageBox.Show("Ты победил!!");
                }
                else
                {
                    hp++;
                    string hpbuff = hp.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (hp == 5)
                    {
                        MessageBox.Show("Ты проиграл!");
                        label1.Text = null;
                        label1.Text = text;
                    }
                }
                textBox2.Text = null;
            }
        }
    }
}
