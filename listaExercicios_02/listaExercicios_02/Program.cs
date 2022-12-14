namespace listaExercicios_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numeroExercicio;
            Console.WriteLine("-----Exercicios da Lista 2 -----");

            numeroExercicio = "Exercicio 1";
            Console.WriteLine($"Resposta do {numeroExercicio} ");

            //1. Caracteres progressivos 1 - Escrever um programa que produza a saída abaixo na tela, para N
            // linhas e usando um caractere lido do teclado(no exemplo, *).Após mostrar uma vez, o programa
            //repete o processo, só parando quando N for zero.

            int valorN;
            string impressa = "";
            int numAConvertido;

            Console.WriteLine("Digite um carater qualquer:");
            string valorDigitado = Console.ReadLine();

            try
            {
                Console.WriteLine("Digite a quantidade de linhas que deseja visualizar o caracter informado:");
                string numA = Console.ReadLine();

                numAConvertido = (ConversorEValidorNumerico.ConverterValidar(numA));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                numAConvertido = 1;
            }


            for (int i = 0; i < numAConvertido; i++)
            {
                impressa += valorDigitado;
                Console.WriteLine(impressa);
            }


            // Maior - Escrever um programa que lê números inteiros até que o número lido seja zero, quando então é mostrado o maior número lido.

            numeroExercicio = "Exercicio 2";
            Console.WriteLine($"Resposta do {numeroExercicio} ");

            int maiorNumero = int.MinValue;
            int contador = 1;

            int numeroConvertido;


            try
            {
                Console.WriteLine("Digite um número:");
                string input = Console.ReadLine();

                numeroConvertido = (ConversorEValidorNumerico.ConverterValidar(input));
                maiorNumero = numeroConvertido;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                numeroConvertido = 1;
            }

            while (numeroConvertido != 0)
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    string input = Console.ReadLine();
                    numeroConvertido = (ConversorEValidorNumerico.ConverterValidar(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    numeroConvertido = 1;
                }

                if (numeroConvertido > maiorNumero)
                {
                    maiorNumero = numeroConvertido;
                }

            }
            Console.WriteLine($"O maior número Digitado foi: {maiorNumero}");

            // Maior e menor - Alterar o programa anterior para que mostre também o menor número lido.
            numeroExercicio = "Exercicio 3";
            Console.WriteLine($"Resposta do {numeroExercicio} ");

            int menorNumero = int.MaxValue;
            int maiorNumero2 = int.MinValue;
            int contador2 = 1;

            int numeroConvertido2;


            try
            {
                Console.WriteLine("Digite um número:");
                string input2 = Console.ReadLine();

                numeroConvertido2 = (ConversorEValidorNumerico.ConverterValidar(input2));
                maiorNumero2 = numeroConvertido2;
                menorNumero = numeroConvertido2;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                numeroConvertido2 = 1;
            }

            while (numeroConvertido2 != 0)
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    string input2 = Console.ReadLine();
                    numeroConvertido2 = (ConversorEValidorNumerico.ConverterValidar(input2));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    numeroConvertido2 = 1;
                }

                if (numeroConvertido2 > maiorNumero2)
                {
                    maiorNumero2 = numeroConvertido2;
                }
                else if (numeroConvertido2 < menorNumero)
                {
                    menorNumero = numeroConvertido2;
                }

            }
            Console.WriteLine($"O maior número Digitado foi: {maiorNumero2}\n O menor número Digitado foi: {menorNumero}");

            // Soma de pares - Implemente um programa que calcula a soma dos números pares
            // compreendidos entre dois números lidos.
            numeroExercicio = "Exercicio 4";
            Console.WriteLine($"Resposta do {numeroExercicio} ");
            int contador3 = 0, numeroConvertido3;
            int[] numerosDigitados = new int[2];
            int soma = 0;
            bool numeroPar;

            try
            {
                while (contador3 < 2)
                {
                    Console.WriteLine($"Digite o {contador3 + 1}° número:");
                    string input3 = Console.ReadLine();

                    numeroConvertido3 = (ConversorEValidorNumerico.ConverterValidar(input3));
                    numerosDigitados[contador3] = numeroConvertido3;

                    contador3++;


                }
                int primeiroNumero = numerosDigitados.Min();
                int segundoNumero = numerosDigitados.Max();

                primeiroNumero = primeiroNumero + 1;

                while (primeiroNumero < segundoNumero)
                {
                    numeroPar = SeparadorNumerosImparEPar.SepararNumerosPares(primeiroNumero);

                    if (numeroPar)
                    {
                        soma += primeiroNumero;
                        primeiroNumero++;
                    }
                    primeiroNumero++;
                }
                Console.WriteLine($"A soma dos números pares entre {numerosDigitados[0]} e {numerosDigitados[1]} = {soma}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                numeroConvertido3 = default;
            }

            //Ímpares múltiplos 1 - Escreva um programa que soma todos os números ímpares múltiplos de
            // três situados na faixa de 1 a 1000.

            numeroExercicio = "Exercicio 5";
            Console.WriteLine($"Resposta do {numeroExercicio} ");
            int numeroInicial = 1;
            int numeroFinal = 1000;
            int somaMultiplosDe3 = 0;

            try
            {
                for (int i = numeroInicial; i <= numeroFinal; i++)
                {
                    if (i % 3 == 0)
                    {
                        somaMultiplosDe3 += i;
                    }
                }
                Console.WriteLine($"A soma dos multiplos de 3, entre 1 e 1000 é: {somaMultiplosDe3}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Ímpares múltiplos 2 - Altere o programa acima de forma que a faixa seja informada pelo
            //usuário, e os números ímpares múltiplos de três sejam mostrados em ordem decrescente.

            numeroExercicio = "Exercicio 6";
            Console.WriteLine($"Resposta do {numeroExercicio} ");
            int[] inputs = new int[2];
            int multiplosConcatenados;

            try
            {
                Console.WriteLine("Digite o número incial:");
                string inputDeInicio = Console.ReadLine();

                inputs[0] = ConversorEValidorNumerico.ConverterValidar(inputDeInicio);

                Console.WriteLine("Digite o número final:");
                string inputFinal = Console.ReadLine();
                inputs[1] = ConversorEValidorNumerico.ConverterValidar(inputFinal);

                int maiorValor = inputs.Max();
                int menorValor = inputs.Min();

                int tamanhoVetorDeMultiplos = DeterminaMultiplos(menorValor, maiorValor);

                int[] array = new int[tamanhoVetorDeMultiplos];
                int j = 0;

                for (int i = menorValor; i <= maiorValor; i++)
                {
                    if (i % 3 == 0)
                    {
                        array[j] = i;
                        j++;
                    }
                }
                Array.Sort(array);
                Console.Write($"\n Os números multiplos de 3 - entre {menorValor} e {maiorValor} são:\n");

                foreach (int i in array)
                {
                    Console.Write(i + ",");
                }




                OrdenacaoDeVetor(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            numeroExercicio = "Exercicio 7";
            Console.WriteLine($"Resposta do {numeroExercicio} ");

            string nome = "fabuloso";
            string nomeAlterado = "";

            nome.ToCharArray();

            foreach (char c in nome)
            {
                nomeAlterado += c + "-";
            }



            Console.Write(nomeAlterado.Remove(nomeAlterado.Length - 1));

        }
        public static int DeterminaMultiplos(int numeroInicial, int numeroFinal)
        {
            int c = 0;

            for (int i = numeroInicial; i <= numeroFinal; i++)
            {
                if (i % 3 == 0)
                {
                    c++;
                }
            }
            return c;
        }

        public static void OrdenacaoDeVetor(int[] vet)
        {
            Array.Reverse(vet);
            Console.WriteLine($"\nOrdem Decrescente dos Multiplos\n");
            foreach (int v in vet)
            {
                Console.Write(v + ",");
            }
        }
    }
    
}