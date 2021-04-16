using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Processamento_de_Imagens
{
    static class Mascara
    {
        public static int[,] getLaplace()
        {
            int[,] mascara = new int[,]
            {
                {0, -1, 0},
                {-1, 4, -1},
                {0, -1, 0},
            };
            return mascara;
        }

        public static int[,] getPrewitt(int x = 0)
        {
            int[,] mascara = null;
            switch(x)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {-1, -1, -1},
                        {0, 0, 0},
                        {1, 1, 1},
                    };
                    break;
                case 1:
                    mascara = new int[,]
                    {
                        {-1, 0, 1},
                        {-1, 0, 1},
                        {-1, 0, 1},
                    };
                    break;
            }
            return mascara;
        }

        public static int[,] getSobel()
        {
            int[,] mascara = new int[,]
            {
                {-1, -2, -1},
                {0, 0, 0},
                {1, 2, 1},
            };
            return mascara;
        }

        public static void preencherTabela(DataGridView dataGridView, int[,] mascara)
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

    }
}
