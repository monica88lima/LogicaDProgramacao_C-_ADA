using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaExercicios_02
{
    internal class SeparadorNumerosImparEPar
    {
        public static bool SepararNumerosPares(int numeral)
        {
            if (numeral % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool SepararNumerosImpares(int numeral)
        {
            if (numeral % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
