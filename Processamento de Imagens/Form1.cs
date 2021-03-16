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
            lstOperacoes.Items.Add(Operacoes.binarizacao);
            lstOperacoes.Items.Add(Operacoes.filtroMedia);
            lstOperacoes.SetSelected(0, true);

            barLimiar.Value = barLimiar.Maximum / 2;
            txtLimiar.Text = barLimiar.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picOriginal.Image = new Bitmap(openFileDialog.FileName);
            }
            txtAlturaOriginal.Text = picOriginal.Image.Height.ToString();
            txtLarguraOriginal.Text = picOriginal.Image.Width.ToString();
            Imagem imagem = new Imagem(new Bitmap(picOriginal.Image));
            lstHistogramaOriginal.Items.Clear();
            foreach (int valor in imagem.getHistograma())
            {
                lstHistogramaOriginal.Items.Add($"{lstHistogramaOriginal.Items.Count} = {valor}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imagem imagemOriginal = new Imagem(new Bitmap(picOriginal.Image));
            Bitmap imagemProcessada = null;
            switch (lstOperacoes.SelectedItem)
            {
                case Operacoes.binarizacao:
                    imagemProcessada = imagemOriginal.getBinarizacao(Int32.Parse(txtLimiar.Text));
                    break;
                case Operacoes.filtroMedia:
                    imagemProcessada = imagemOriginal.getFiltroMedia();
                    break;
            }
            picProcessada.Image = imagemProcessada;
            lstHistogramaProcessada.Items.Clear();
            foreach (int valor in new Imagem(imagemProcessada).getHistograma())
            {
                lstHistogramaProcessada.Items.Add($"{lstHistogramaProcessada.Items.Count} = {valor}");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtLimiar.Text = barLimiar.Value.ToString();
        }
    }
}
