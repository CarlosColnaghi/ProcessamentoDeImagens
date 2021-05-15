using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Processamento_de_Imagens
{
    public static class Interface
    {

        public static void preencherDimensoes(PictureBox pictureBox, TextBox altura, TextBox largura)
        {
            altura.Text = pictureBox.Image.Height.ToString();
            largura.Text = pictureBox.Image.Width.ToString();
        }

        public static void preencherMascara(DataGridView dataGridView, int[,] mascara)
        {
            dataGridView.ClearSelection();
            dataGridView.RowCount = mascara.GetLength(0);
            dataGridView.ColumnCount = mascara.GetLength(1);
            for (int i = 0; i < mascara.GetLength(0); i++)
            {
                for (int j = 0; j < mascara.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = mascara[i, j];
                }
            }
            dataGridView.ClearSelection();
        }
    
        public static void preencherHistograma(ListBox listBox, int[] histograma)
        {
            listBox.Items.Clear();
            foreach (int valor in histograma)
            {
                listBox.Items.Add($"{listBox.Items.Count} = {valor}");
            }
        }

        public static void preencherHistograma(Chart chart, int[] histograma)
        {
            chart.Series[0].Points.Clear();
            chart.ChartAreas[0].AxisX.Maximum = histograma.Length - 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            for (int i = 0; i < histograma.Length; i++)
            {
                chart.Series[0].Points.AddXY(i, histograma[i]);
            }
        }
    }
}
