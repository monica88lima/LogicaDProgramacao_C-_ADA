namespace jogoDaForca_Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavrasDaForca = new string[28] { "AMARELO","BRANCO", "AZUL","VIOLETA","CACHORRO","PASSARINHO","GATO",
                    "PEIXE","PIJAMA","CUECA","CASACO","JAQUETA","ESTOJO","CADERNO", "TESOURA","CORRETIVO","BOLO","MOUSSE","LASANHA",
                    "PIZZA", "CANECA", "GARFO", "ESCUMADEIRA","PANELA","PEDIATRA","OFTALMOLOGISTA","CARDIOLOGISTA","NEUROLOGISTA" };

            Random random = new Random();
            string palavraSorteada = palavrasDaForca[random.Next(palavrasDaForca.Length)];

            string temaDaPalavra = Tema(palavraSorteada);

            //Console.WriteLine("DICA 1 - A palavra sorteada têm: " + palavraSorteada.Length + " letras! ");
            Console.WriteLine();
            // Console.WriteLine("DICA 2 - O tema é: " + temaDaPalavra);

            Console.WriteLine(palavraSorteada);

            palavraSorteada.ToCharArray();

            int tentativas = 6;
            char letraDigitada;
            int contador = 0;
            char[] palavraEmFormacao = new char[palavraSorteada.Length];
            char[] letrasErradas = new char[tentativas];


            while (tentativas > 0 && tentativas <= 6)
            {


                Console.WriteLine("DICA 1 - A palavra sorteada têm: " + palavraSorteada.Length + " letras! ");
                Console.WriteLine("DICA 2 - O tema é: " + temaDaPalavra);
                Console.WriteLine();
                Console.WriteLine($"Número de tentativas Restantes: {tentativas} ");

                Console.WriteLine("---- Jogo da Forca ---");

                Console.WriteLine();

                Console.WriteLine("Digite uma Letra:");
                letraDigitada = char.Parse(Console.ReadLine().ToUpper());

                if (letrasErradas.Contains(letraDigitada))
                {
                    Console.WriteLine("Letra Repetida");
                    continue;
                }

                if (palavraSorteada.Contains(letraDigitada))
                {
                    for (int i = 0; i < palavraSorteada.Length; i++)
                    {

                        if (letraDigitada == palavraSorteada[i])
                        {
                            palavraEmFormacao[i] = letraDigitada;
                        }

                    }
                }

                else
                {
                    Console.WriteLine($"A letra digitada não existe na palavra-chave");
                    letrasErradas[contador] = letraDigitada;

                    contador++;
                    tentativas--;


                }

                Console.Clear();
                Console.WriteLine("Palavra da Forca!!!");

                foreach (char A in palavraEmFormacao)
                {
                    Console.Write(A + " - ");

                }
                Console.WriteLine();

                Console.WriteLine("Letras Digitadas Que não estão na Palavra");

                Console.WriteLine();

                foreach (char A in letrasErradas)
                {
                    Console.Write(A + " - ");

                }
                Console.WriteLine();

            }



        }
        static string Tema(string palavra)
        {
            string tematica = " * ";

            switch (palavra)
            {
                case "AMARELO":
                case "BRANCO":
                case "AZUL":
                case "VIOLETA":
                    tematica = "COR";
                    break;

                case "CACHORRO":
                case "PASSARINHO":
                case "GATO":
                case "PEIXE":
                    tematica = "BICHINHO DE ESTIMAÇÃO";
                    break;

                case "PIJAMA":
                case "CUECA":
                case "CASACO":
                case "JAQUETA":
                    tematica = "VESTIMENTA";
                    break;

                case "ESTOJO":
                case "CADERNO":
                case "TESOURO":
                case "CORRETIVO":
                    tematica = "MATERIAL ESCOLAR";
                    break;

                case "BOLO":
                case "MOUSSE":
                case "LASANHA":
                case "PIZZA":
                    tematica = "COMIDA";
                    break;

                case "CANECA":
                case "GARFO":
                case "ESCUMADEIRA":
                case "PANELA":
                    tematica = "UTENSILIOS DE COZINHA";
                    break;

                case "PEDIATRA":
                case "OFTALMOLOGISTA":
                case "CARDIOLOGISTA":
                case "NEUROLOGISTA":
                    tematica = "ESPECIALIDADE MEDICA";
                    break;


            }
            return tematica;
        }

    }

}