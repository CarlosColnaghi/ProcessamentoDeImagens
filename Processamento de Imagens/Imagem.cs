using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Processamento_de_Imagens
{
    class Imagem
    {
        private Bitmap imagem;

        public Imagem()
        {
        }

        public Imagem(Bitmap imagem)
        {
            this.imagem = imagem;
        }

        public Imagem(String caminho)
        {
            this.imagem = new Bitmap(caminho);
        }

        public Bitmap getImagem()
        {
            return imagem;
        }

        public void setImagem(Bitmap imagem)
        {
            this.imagem = imagem;
        }

        public Color[][] getMatriz()
        {
            Color[][] matriz = new Color[imagem.Height][];
            for (int i = 0; i < imagem.Height; i++)
            {
                matriz[i] = new Color[imagem.Width];
                for (int j = 0; j < imagem.Width; j++)
                {
                    matriz[i][j] = imagem.GetPixel(i, j);
                    Console.WriteLine(matriz[i][j]);
                }
            }
            return matriz;
        }

        public Bitmap binarizacao(int limiar)
        {
            Color[][] matriz = getMatriz();
            Bitmap imagem = new Bitmap(this.imagem);
            for (int i = 0; i < this.imagem.Height; i++)
            {
                for (int j = 0; j < this.imagem.Width; j++)
                {
                    if (matriz[i][j].R <= limiar)
                    {                
                        imagem.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        imagem.SetPixel(i, j, Color.White);
                    }
                }
            }
            return imagem;
        }

        public int[] getHistograma()
        {
            int[] histograma = new int[256];
            for (int i = 0; i < 255; i++)
            {
                histograma[i] = 0;
            }
            Color[][] matriz = getMatriz();
            for (int i = 0; i < imagem.Height; i++)
            {
                for (int j = 0; j < imagem.Width; j++)
                {
                    histograma[matriz[i][j].R] += 1;
                }
            }
            return histograma;
        }

    }
}
