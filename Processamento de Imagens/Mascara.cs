using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Processamento_de_Imagens
{
    static class Mascara
    {
        public static int[,] getLaplace(int tipo = 0)
        {
            int[,] mascara = null;
            switch (tipo)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {0, -1, 0},
                        {-1, 4, -1},
                        {0, -1, 0},
                    };
                    break;
                case 1:
                    mascara = new int[,]
                    {
                        {-1, -1, -1},
                        {-1, 8, -1},
                        {-1, -1, -1},
                    };
                    break;
            }    
            return mascara;
        }

        public static int[,] getPrewitt(int tipo = 0)
        {
            int[,] mascara = null;
            switch(tipo)
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

        public static int[,] getSobel(int tipo = 0)
        {
            int[,] mascara = null;
            switch (tipo)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {-1, -2, -1},
                        {0, 0, 0},
                        {1, 2, 1},
                    };
                    break;
                case 1:
                     mascara = new int[,]
                    {
                        {-1, 0, 1},
                        {-2, 0, 2},
                        {-1, 0, 1},
                    };
                    break;
            }
                
            return mascara;
        }

        public static int[,] getRoberts(int tipo = 0)
        {
            int[,] mascara = null;
            switch (tipo)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {1, 0},
                        {0, -1}
                    };
                    break;
                case 1:
                    mascara = new int[,]
                   {
                        {0, 1},
                        {-1, 0}
                   };
                    break;
            }

            return mascara;
        }

        public static int[,] getLaplaceMaisOriginal(int tipo = 0)
        {
            int[,] mascara = null;
            switch (tipo)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {0, -1, 0},
                        {-1, 5, -1},
                        {0, -1, 0},
                    };
                    break;
                case 1:
                    mascara = new int[,]
                   {
                        {-1, -1, -1},
                        {-1, 9, -1},
                        {-1, -1, -1},
                   };
                    break;
            }

            return mascara;
        }

        public static int[,] getKirsch(int tipo = 0)
        {
            int[,] mascara = null;
            switch (tipo)
            {
                case 0:
                    mascara = new int[,]
                    {
                        {5, 5, 5},
                        {-3, 0, -3},
                        {-3, -3, -3},
                    };
                    break;
                case 1:
                    mascara = new int[,]
                   {
                        {-3, -3, -3},
                        {-3, 0, -3},
                        {5, 5, 5},
                   };
                    break;
            }

            return mascara;
        }

        public static int getOrdem(int[,] mascara)
        {
            return mascara.GetLength(0);
        }
    }
}
