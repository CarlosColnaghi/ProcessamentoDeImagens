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
                }
            }
            return matriz;
        }

        public Bitmap getBinarizacao(int limiar)
        {
            Bitmap imagem = new Bitmap(this.imagem);
            for (int i = 0; i < this.imagem.Height; i++)
            {
                for (int j = 0; j < this.imagem.Width; j++)
                {
                    if (this.imagem.GetPixel(i, j).R <= limiar)
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
            for (int i = 0; i < imagem.Height; i++)
            {
                for (int j = 0; j < imagem.Width; j++)
                {
                    histograma[this.imagem.GetPixel(i, j).R] += 1;
                }
            }
            return histograma;
        }

        public Bitmap getFiltroMedia()
        {
            Bitmap imagem = new Bitmap(this.imagem);
            for(int i = 1; i <= imagem.Height-2; i++)
            {
                for(int j = 1; j <= imagem.Width-2; j++)
                {
                    int soma = 0;
                    for(int k = i-1; k <= i+1; k++)
                    {
                        for(int l = j-1; l <= j+1; l++)
                        {
                            soma += imagem.GetPixel(k, l).R;   
                        }
                    }
                    int media = soma / 9;
                    imagem.SetPixel(i, j, Color.FromArgb(255, media, media, media));
                }
            }
            return imagem;
        }

        public Bitmap processar(int[,] mascara)
        {
            Bitmap imagem = new Bitmap(this.imagem);
            for (int i = 1; i <= this.imagem.Height - 2; i++)
            {
                for (int j = 1; j <= this.imagem.Width - 2; j++)
                {
                    int soma = 0;
                    for (int k = i - 1, m = 0; k <= i + 1; k++, m++)
                    {
                        for (int l = j - 1, n = 0; l <= j + 1; l++, n++)
                        {
                            soma += this.imagem.GetPixel(k, l).R * mascara[m, n];
                            Console.WriteLine("${soma} ${k}, ${l} = ${m}, ${n}");
                        }
                    }
                    if(soma < 0) 
                    {
                        soma = 0;
                    }else if(soma > 255)
                    {
                        soma = 255;
                    }
                    imagem.SetPixel(i, j, Color.FromArgb(255, soma, soma, soma));
                }
            }
            return imagem;
        }

        public Bitmap getFiltroRealce()
        {
            return processar(Mascara.getLaplaciano());
        }
    }
}
