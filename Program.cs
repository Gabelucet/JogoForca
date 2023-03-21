/*JOGO DA FORCA !!!!*/
using System;

namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta();
        }

        static void inicio()
        {
            //coloquei o Thread.Sleep(2000) para a mensagem aparecer aos poucos, achei que daria um efeito legal
            Console.Clear();
            Console.WriteLine("SEJA BEM VINDO AO JOGO DA FORCA DO GABE");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos lá conhecer as regras: ");
            Thread.Sleep(1500);
            Console.WriteLine("Todos os temas tem 5 vidas");
            Thread.Sleep(1500);
            Console.WriteLine("Atualmente temos 3 temas");
            Thread.Sleep(1500);
            Console.WriteLine("Cada tema tem 50 palavras, que são escolhidas de forma aleatória");
            Thread.Sleep(1500);
            Console.WriteLine(
                "Está pronto?\n\n            ... Pressione Enter para continuar ...    "
            );
            Console.ReadKey();
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine(
                "Qual será o seu tema?\n1 - Para fruta\n2 - Para Animal \n3 - Para time\n0 - Para Sair do programa"
            );
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Fruta();
                    break;
                case 2:
                    Animal();
                    break;
                case 3:
                    Time();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida  ...  Voltando para o inicio  ...");
                    Thread.Sleep(1500);
                    inicio();
                    break;
            }
        }

        static void Validacao(string palavraEscolhida, string palavraCodificada)
        {
            int vida = 6;
            while (vida >= 1)
            {
                Console.WriteLine("A palavra escolhida tem " + palavraEscolhida.Length + " letras");
                Desenho(vida);
                Console.WriteLine("\n          " + palavraCodificada);
                Console.Write("\nMe informe uma letra: ");
                string letra = Console.ReadLine();
                String letraMaiscula = letra.ToUpper();

                if (palavraEscolhida.Contains(letraMaiscula))
                {
                    int posicao = palavraEscolhida.IndexOf(letraMaiscula);
                    while (posicao >= 0)
                    {
                        palavraCodificada = palavraCodificada
                            .Remove(posicao, 1)
                            .Insert(posicao, letraMaiscula);
                        posicao = palavraEscolhida.IndexOf(letraMaiscula, posicao + 1);
                    }

                    Console.WriteLine("\nParabéns!!! Temos a letra " + letraMaiscula);
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    vida--;
                    Console.WriteLine("\nNão temos a letra " + letraMaiscula + ", nessa palavra ");
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                if (palavraCodificada.IndexOf("_") == -1)
                {
                    Console.WriteLine("Parabéns você venceu");
                    continuarJogando();
                    
                }

                if (vida == 0)
                {
                    Console.WriteLine("\nGAME OVER!!!!");
                    Console.WriteLine(" _____");
                    Console.WriteLine("|     |");
                    Console.WriteLine("|     O");
                    Console.WriteLine("|    /|\\");
                    Console.WriteLine("|    / \\");
                    Console.WriteLine("|");
                    Console.WriteLine("|___");

                    Thread.Sleep(2000);
                    Console.Clear();
                    continuarJogando();
                }
            }
        }

        static void Fruta()
        {
            Console.Clear();

            //Aqui ficara as palavras que serão escolhidas para o jogo da forca
            string[] listaDePalavras =
            {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "AMEIXA",
                "ARAÇA",
                "AÇAI",
                "BACABA",
                "BURITI",
                "CAJU",
                "CAJA",
                "CARAMBOLA",
                "COCO",
                "CUPUAÇU",
                "FIGO",
                "GOIABA",
                "GRAVIOLA",
                "GUABIROBA",
                "GUARANA",
                "JABUTICABA",
                "JACA",
                "JATOBA",
                "JENIPAPO",
                "KIWI",
                "LARANJA",
                "LIMAO",
                "MAMAO",
                "MANGA",
                "MANGABA",
                "MARACUJA",
                "MELANCIA",
                "MURICI",
                "NECTARINA",
                "PERA",
                "PESSEGO",
                "PEQUI",
                "PINHA",
                "PITANGA",
                "PITOMBA",
                "ROMA",
                "SAPOTI",
                "SIRIGUELA",
                "TANGERINA",
                "TUCUMA",
                "UMBU",
                "UXI",
                "UVA",
                "TOMATE"
            };

            //Aqui será sorteadado as palavras
            Random paralvraAleatoria = new Random();
            int localização = paralvraAleatoria.Next(0, 0);
            string palavraEscolhida = listaDePalavras[localização];

            //Aqui iremos codificar as palavras
            string codificador = "".PadLeft(palavraEscolhida.Length, '_');
            string palavraCodificada = palavraEscolhida.Replace(palavraEscolhida, codificador);

            //Aqui vamos fazer as validações
            Validacao(palavraEscolhida, palavraCodificada);
        }

        static void Time() { }

        static void Animal() { }

        static void Desenho(int vida)
        {
            if (vida == 5)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }

            if (vida == 4)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|     |");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }

            if (vida == 3)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|     |\\");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }

            if (vida == 2)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|\\");
                Console.WriteLine("|      ");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }

            if (vida == 1)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    /|\\");
                Console.WriteLine("|      \\");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }
        }

        static void continuarJogando(){
            Console.WriteLine("\nDeseja continuar jogando?");
                    Console.WriteLine("1 - PARA SIM\n2 - PARA NÃO");
                    int continuarJogando = int.Parse(Console.ReadLine());

                    switch (continuarJogando)
                    {
                        case 1:
                            Console.WriteLine("Voltando para o inicio");
                            Thread.Sleep(1000);
                            inicio();
                            break;
                        case 2:
                            Console.WriteLine("Saindo da aplicação");
                            Thread.Sleep(1000);
                            Console.Clear();
                            System.Environment.Exit(2);
                            break;
                        default:
                            Console.WriteLine(". . .Opção invalida. . .");
                            Console.WriteLine("Voltando para o menu");
                            Thread.Sleep(1000);
                            inicio();
                            break;
                    }
        }
    }
}
