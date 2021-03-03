using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Processamento_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             lstOperacoes.Items.Add("Binarização");
             lstOperacoes.Items.Add("Média");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picOriginal.Image = new Bitmap(openFileDialog.FileName);
            }
            txtAltura.Text = picOriginal.Image.Height.ToString();
            txtLargura.Text = picOriginal.Image.Width.ToString();
            Imagem imagem = new Imagem(new Bitmap(picOriginal.Image));
            foreach (int valor in imagem.getHistograma())
            {
                lstHistograma.Items.Add($"{lstHistograma.Items.Count} = {valor}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagem imagem = new Imagem(new Bitmap(picOriginal.Image));
            //picProcessada.Image = imagem.getBinarizacao(Int32.Parse(txtLimiar.Text));
            picProcessada.Image = imagem.getFiltroMedia();
            foreach (int valor in imagem.getHistograma())
            {
                lstHistograma.Items.Add($"{lstHistograma.Items.Count} = {valor}");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtLimiar.Text = barLimiar.Value.ToString();
        }
    }
}
