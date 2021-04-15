using System;
using System.Collections.Generic;
using System.Text;

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

        public static int[,] getPrewitt()
        {
            int[,] mascara = new int[,]
            {
                {-1, -1, -1},
                {0, 0, 0},
                {1, 1, 1},
            };
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

    }
}
