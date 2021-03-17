using System;
using System.Collections.Generic;
using System.Text;

namespace Processamento_de_Imagens
{
    static class Mascara
    {
        public static int[,] getLaplaciano()
        {
            int[,] mascara = new int[,]
            {
                {0, -1, 0},
                {-1, 4, -1},
                {0, -1, 0},
            };
            return mascara;
        }
    }
}
