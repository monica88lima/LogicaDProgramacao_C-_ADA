using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaExercicios_02
{
    internal class ConversorEValidorNumerico
    {
        public static int ConverterValidar(string numDigitado)
        {

            bool validaEntrada = int.TryParse(numDigitado, out int numeroDigitado);

            if (!validaEntrada)
                throw new Exception("Número inválido. Foi atribuido o numéro 1 a tentativa.");

            return numeroDigitado;

        }
    }
}
