/*JOGO DA FORCA !!!!*/
using System;

namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {
            inicio();
        }

        static void inicio()
        {
            //coloquei o Thread.Sleep(2000) para a mensagem aparecer aos poucos, achei que daria um efeito legal
            Console.Clear();
            Console.WriteLine("SEJA BEM VINDO AO JOGO DA FORCA DO GABE");Thread.Sleep(1000);
            Console.WriteLine("Vamos lá conhecer as regras: ");Thread.Sleep(1500);
            Console.WriteLine("Todos os temas tem 5 vidas");Thread.Sleep(1500);
            Console.WriteLine("Atualmente temos 3 temas");
            Console.WriteLine("Você deverá escolher a sua dificuldade");Thread.Sleep(1500);
            Console.WriteLine("Sendo: ");Thread.Sleep(1500);
            Console.WriteLine("Fácil = 10 palavras daquele tema");Thread.Sleep(1500);
            Console.WriteLine("Médio = 20 palavras daquele tema");Thread.Sleep(1500);
            Console.WriteLine("Difícil = 30 palavras daquele tema");Thread.Sleep(1500);
            Console.WriteLine("Missão impossível = 50 palavras daquele tema"); Thread.Sleep(1500);
            Console.WriteLine("Está pronto?\n\n            ... Pressione Enter para continuar ...    ");
            Console.ReadKey();
            Console.Clear();
            Thread.Sleep(1000)
            Console.WriteLine("Qual será o seu tema?\n1 - Para fruta\n2 - Para Animal \n3 - Para tima\n0 - Para Sair do programa");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Fruta(); break;
                case 2: Animal(); break;
                case 3: Time(); break;
                case 0: System.Environment.Exit(0); break
                default:Console.WriteLine("Opção invalida  ...  Voltando para o inicio  ..."); Thread.Sleep(1500);inicio();break;
            }

        }

        static void Fruta()
        {
            Console.Clear();
            //Aqui ficara as frutas que serão escolhidas para o jogo da forca
            string[] fruits = { "BANANA" };

            //Aqui será sorteadado as frutas e palavras
            Random frutaAleatoria = new Random();
            int localização = frutaAleatoria.Next(0, fruits.Length);
            string frutaEscolhida = fruits[localização];

            //Aqui iremos codificar as palavras
            string codificador = "".PadLeft(frutaEscolhida.Length, '*');
            string frutaCodificada = frutaEscolhida.Replace(frutaEscolhida, codificador);

            //Aqui vamos fazer as validações
            int vida = 5;
            while (vida >= 1)
            {
                //Aqui iremos perguntar a letra para o user
                Console.Write("Me informe uma letra: ");
                string letra = Console.ReadLine();
                String letraMaiscula = letra.ToUpper();

                if (frutaEscolhida.Contains(letraMaiscula))
                {
                    int posicao = frutaEscolhida.IndexOf(letraMaiscula);
                    while (posicao >= 0)
                    {
                        frutaCodificada = frutaCodificada
                            .Remove(posicao, 1)
                            .Insert(posicao, letraMaiscula);
                        posicao = frutaEscolhida.IndexOf(letraMaiscula, posicao + 1);
                    }

                    Console.WriteLine("\nParabéns!!! Temos a letra " + letraMaiscula);
                    Console.WriteLine("\n" + frutaCodificada);
                }
                else
                {
                    vida--;
                    Console.WriteLine("\nNão temos a letra " + letraMaiscula + ", nessa palavra ");
                    Console.WriteLine("Sua vida é " + vida);

                    desenho(vida);
                }
            }
        }

        static void Time(){}
        static void Animal(){}

        static void desenho(int vida)
        {
            if (vida == 4)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     O");
                Console.WriteLine("|    ");
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
                Console.WriteLine("|    ");
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
            }
        }
    }
}
