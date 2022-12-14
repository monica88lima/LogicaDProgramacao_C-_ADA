namespace listaExercicios_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1 - Exercicios");
            Console.WriteLine("Exercicio 2");
            ////Calcule as expressões abaixo, observando a precedência dos operadores. Escreva um programa que mostre na tela o resultado de cada expressão e confira seus cálculos.
            //26 + 115 =
            //20 / (-2) / 5 =
            //20 / 22 =
            //(3 + 9) / 34 =
            //(56 / (3 + 2) - 154) / 6 - 4 =
            //4 + 322 - 72 / (9 - 2)

            double calculo1 = 26 + 115;
            Console.WriteLine($"O resultado da Expressão: 26 + 115  = {calculo1} \n");

            double calculo2 = 20 / -2 / 5;
            Console.WriteLine($"O resultado da Expressão: 20 / (-2) / 5  = {calculo2}\n ");

            double calculo3 = 20.0 / 22;
            Console.WriteLine($"O resultado da Expressão: 20 / 22  = {calculo3} \n");

            double calculo4 = (3 + 9) / 34.0;
            Console.WriteLine($"O resultado da Expressão: (3 + 9) / 34 = {calculo4} \n");

            double calculo5 = (56.0 / (3 + 2) - 154) / 6 - 4;
            Console.WriteLine($"O resultado da Expressão :(56 / (3 + 2) - 154) / 6 - 45  = {calculo5} \n");

            double calculo6 = 4 + 322 - 72.0 / (9 - 2);
            Console.WriteLine($"O resultado da Expressão :4 + 322 - 72 / (9 - 2) = {calculo6} \n");
            Console.WriteLine();



            Console.WriteLine("Exercicio 3");
            ////Escreva um programa que lê nome e sobrenome, e mostra na tela as iniciais.
            Console.WriteLine("Digite seu Primeiro Nome:");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite seu Sobrenome:");
            string sobreNome = Console.ReadLine().ToUpper();
            Console.Clear();


            nome.ToCharArray();
            sobreNome.ToCharArray();

            Console.WriteLine($"Sua Iniciais: {nome[0]} {sobreNome[0]}");

            Console.WriteLine("Exercicio 4\n");
            //Reescreva o programa anterior para mostrar na tela as letras finais do nome e
            // sobrenome.

            Console.WriteLine($"Ultima Letra do seu nome: {nome[nome.Length - 1]} \nUltima Letra do seu Sobrenome: {sobreNome[sobreNome.Length - 1]}");
            Console.WriteLine();


            Console.WriteLine("Exercicio 5\n");
            ////A LBV fez um sorteio cujos bilhetes continham números de 6 dígitos. O sorteio foi baseado nos dois primeiros prêmios da loteria federal,
            ////sendo o número sorteado formado pelos três últimos dígitos do primeiro e do segundo prêmio. Por exemplo, se o primeiro prêmio fosse 34.582
            ////e o segundo 54.098, o número da LBV seria 582.098. Escreva um programa que lê os dois prêmios e retorna o número sorteado.


            Console.WriteLine("Digite os 6 digitos do número do prêmio:");
            string primeiroSorteio = Console.ReadLine();
            string numerosIniciais = primeiroSorteio.Remove(0, 3);




            Console.WriteLine("Digite os 6 digitos do número do prêmio:");
            string segundoSorteio = Console.ReadLine();
            string numerosFinais = segundoSorteio.Remove(0, 3);

            Console.WriteLine($"O numero sorteado da LBV é : {numerosIniciais}.{numerosFinais}\n");


            Console.WriteLine("Exercicio 6\n");
            //Multiplicação rápida - Um algoritmo para multiplicação rápida por 11 de números de 2 dígitos funciona assim: para multiplicar 81 x 11, some os dígitos do número
            //(8 + 1 = 9) e insira o resultado entre os dígitos (891). Se a soma der maior que 9, incremente o dígito da esquerda: 56 x 11 = 616. Faça um programa que efetue
            //multiplicações por 11 usando este algoritmo.





            Console.WriteLine("Digite um número com 2 digitos: ");
            string numeroDigitado = (Console.ReadLine());



            char[] vetAlgrismo = numeroDigitado.ToCharArray();

            var primeiro = ConverteParaNumero(vetAlgrismo[0].ToString());
            var segundo = ConverteParaNumero(vetAlgrismo[1].ToString());
            int calculo = primeiro + segundo;



            if (calculo <= 9)
            {

                Console.WriteLine($"{numeroDigitado} X 11 = {primeiro}{calculo}{segundo}");


            }
            else
            {
                string numeroMeio = calculo.ToString();
                primeiro += 1;


                Console.WriteLine($"{numeroDigitado} X 11 = {primeiro}{numeroMeio.Remove(0, 1)}{segundo}");
            }




        }


        public static int ConverteParaNumero(string numeroLiteral)
        {
            string numDigitado = numeroLiteral;
            int numeroConvertido = int.Parse(numDigitado);
            return numeroConvertido;
        }
    }
    
}