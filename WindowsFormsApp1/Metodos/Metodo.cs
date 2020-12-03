using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Metodo
    {
        public static string procesofactorial(int b)
        {
            int j;
            double re = 1;
            string a;
            for (j = 1; j <= b; j++)
            {
                re = re * j;
            }
            a = re + Environment.NewLine;
            return a;
        }
    }
}
