﻿using System;
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
                    histograma[this.imagem.GetPixel(j, i).R] += 1;
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
                            soma += imagem.GetPixel(l, k).R;   
                        }
                    }
                    int media = soma / 9;
                    imagem.SetPixel(j, i, Color.FromArgb(255, media, media, media));
                }
            }
            return imagem;
        }

        private Bitmap processar(int[,] mascara)
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
                            soma += this.imagem.GetPixel(l, k).R * mascara[m, n];
                        }
                    }
                    if(soma < 0) 
                    {
                        soma = 0;
                    }else if(soma > 255)
                    {
                        soma = 255;
                    }
                    imagem.SetPixel(j, i, Color.FromArgb(255, soma, soma, soma));
                }
            }
            return imagem;
        }

        public Bitmap getFiltroLaplace(int mascara = 0)
        {
            return processar(Mascara.getLaplace(mascara));
        }

        public Bitmap getFiltoPrewitt(int mascara = 0)
        {
            return processar(Mascara.getPrewitt(mascara));
        }

        public Bitmap getFiltoSobel(int mascara = 0)
        {
            return processar(Mascara.getSobel(mascara));
        }

        //TODO: Refatorar a função getFiltroRoberts();
        public Bitmap getFiltroRoberts()
        {
            int[,] mascara = new int[,]
            {
                {1, 0},
                {0, -1}
            };
            Bitmap imagem = new Bitmap(this.imagem);
            for(int i = 0; i <= this.imagem.Height-2; i++)
            {
                for(int j = 0; j <= this.imagem.Width-2; j++)
                {
                    int soma = 0;
                    for(int k = i, m = 0; k <= i+1; k++, m++)
                    {
                        for(int l = j, n = 0; l <= j+1; l++, n++)
                        {
                            soma += this.imagem.GetPixel(l, k).R * mascara[m, n];
                        }
                    }
                    if (soma < 0)
                    {
                        soma = soma * -1;
                    }
                    imagem.SetPixel(j, i, Color.FromArgb(255, soma, soma, soma));
                }
            }
            return imagem;
        }

        public Bitmap getEqualizacao()
        {
            Bitmap imagem = new Bitmap(this.imagem.Width, this.imagem.Height);
            int[] histograma = getHistograma();
            int[] histogramaNovo = new int[histograma.Length];
            int auxiliar = 0, ideal = (this.imagem.Width * this.imagem.Height) / histograma.Length;
            for(int i = 0; i < histograma.Length; i++)
            {
                auxiliar += histograma[i];
                if(((auxiliar/ideal)-1) > 0){
                    histogramaNovo[i] = (auxiliar / ideal) - 1;
                }
                else
                {
                    histogramaNovo[i] = 0;
                }
            }
            for(int i = 0; i < this.imagem.Height; i++)
            {
                for(int j = 0; j < this.imagem.Width; j++)
                {
                    int cor = this.imagem.GetPixel(j, i).R;
                    imagem.SetPixel(j, i, Color.FromArgb(255, histogramaNovo[cor], histogramaNovo[cor], histogramaNovo[cor]));
                }
            }
            return imagem;
        }

        public Bitmap getCanal(int canal)
        {
            Bitmap imagem = new Bitmap(this.imagem);
            for (int i = 0; i < this.imagem.Width; i++)
            {
                for (int j = 0; j < this.imagem.Height; j++)
                {
                    Color pixel = this.imagem.GetPixel(i, j);
                    switch (canal)
                    {
                        case 0:
                            imagem.SetPixel(i, j, Color.FromArgb(255, pixel.R, 0, 0));
                            break;
                        case 1:
                            imagem.SetPixel(i, j, Color.FromArgb(255, 0, pixel.G, 0));
                            break;
                        case 2:
                            imagem.SetPixel(i, j, Color.FromArgb(255, 0, 0, pixel.B));
                            break;
                    }
                }
            }
            return imagem;
        }

    }
}
