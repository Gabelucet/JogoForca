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
            Console.WriteLine("SEJA BEM VINDO AO JOGO DA FORCA DO GABE");
            Thread.Sleep(1000);
            Console.WriteLine("Vamos lá conhecer as regras: ");
            Thread.Sleep(1500);
            Console.WriteLine("Todos os temas tem 6 vidas");
            Thread.Sleep(1500);
            Console.WriteLine("Atualmente temos 3 temas");
            Thread.Sleep(1500);
            Console.WriteLine("Cada tema tem 50 palavras, que são escolhidas de forma aleatória");
            Thread.Sleep(1500);
            Console.WriteLine(
                "Está pronto?\n\n            ... Pressione Enter para continuar ...    "
            );
            Console.ReadKey();
            MenuSelecao();
        }
 
        static void MenuSelecao()
        {
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine(
                "Qual será o seu tema?\n1 - Para fruta\n2 - Para Animal \n3 - Para time\n0 - Para Sair do programa"
            );
            Console.Write("\nSua resposta: ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    string[] listaDeFrutas =
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
                    CodificarDasPalavras(listaDeFrutas);
                    break;
                case 2:
                    string[] listaDeAnimais =
                    {
                        "ABELHA",
                        "ARANHA",
                        "AGUIA",
                        "BALEIA",
                        "CARCARA",
                        "CANGURU",
                        "CHITA",
                        "COALA",
                        "COBRA",
                        "CONDOR",
                        "CROCODILO",
                        "ELEFANTE",
                        "FALCAO",
                        "FORMIGA",
                        "FOCA",
                        "GAVIAO",
                        "GIRRAFA",
                        "GORILA",
                        "HIPOPOTAMO",
                        "JACARE",
                        "JAGUATIRICA",
                        "LEAO",
                        "LEOPARDO",
                        "LOBO",
                        "MACACO",
                        "MEDUSA",
                        "MORSA",
                        "ONÇA",
                        "ORCA",
                        "PANDA",
                        "PEIXE",
                        "PINGUIM",
                        "POLVO",
                        "RAPTOR",
                        "RINOCERONTE",
                        "SURICATE",
                        "TARTARUGA",
                        "TIGRE",
                        "TUBARÃO",
                        "URSO",
                        "ZEBRA"
                    };
                    CodificarDasPalavras(listaDeAnimais);
                    break;
                case 3:
                    string[] listaDeTimes =
                    {
                        "BARCELONA",
                        "LIVERPOOL",
                        "CHELSEA",
                        "BAYERN MUNICH",
                        "JUVENTUS",
                        "MILAN",
                        "BENFICA",
                        "SPORTING",
                        "PORTO",
                        "CELTIC",
                        "RANGERS",
                        "ARSENAL",
                        "TOTTENHAM",
                        "SEVILLA",
                        "VALENCIA",
                        "PSV",
                        "AJAX",
                        "FLAMENGO",
                        "CORINTHIANS",
                        "SANTOS",
                        "PALMEIRAS",
                        "GREMIO",
                        "INTERNACIONAL",
                        "CRUZEIRO",
                        "FLUMINENSE",
                        "BOTAFOGO",
                        "CHAPECOENSE",
                        "GOIAS",
                        "CEARA",
                        "FORTALEZA",
                        "SANTA CRUZ",
                        "SPORT",
                        "NAUTICO",
                        "ABC",
                        "PAYSANDU",
                        "REMO",
                        "JUVENTUDE",
                        "PSG",
                        "LAZIO",
                        "GUARANI",
                        "CRICIUMA",
                        "NACIONAL"
                    };
                    CodificarDasPalavras(listaDeTimes);
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
        //Aqui está todo o jogo da forca, as validações para fazer o desenho da forca, contar as vidas e diminuir a vida
     
        static void Validacao(string palavraEscolhida, string palavraCodificada)
        {
            int vida = 6;
            string letrasInformadas = "";
            while (vida >= 1)
            {
                string letraMaiscula = "";
                Console.WriteLine("A palavra escolhida tem " + palavraEscolhida.Length + " letras");
                Console.WriteLine(
                    "\nAs seguintes letras já foram informadas: \n" + letrasInformadas
                );
                Desenho(vida);
                Console.WriteLine("\n          " + palavraCodificada);
                Console.Write("\nMe informe uma letra: ");
                string letra = Console.ReadLine();
                letraMaiscula = letra.ToUpper();

                //Verificação se a letra já foi informad
                if (letrasInformadas.Contains(letraMaiscula))
                {
                    Console.WriteLine(
                        "\n----------ATENÇÃO!! A letra já foi informada---------------"
                    );
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }
                letrasInformadas = letrasInformadas + " " + letraMaiscula + " ";

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
                    Console.Write("\nA palavra era: " + palavraEscolhida);
                    Thread.Sleep(3000);
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

                    Console.Write("\nA palavra era: " + palavraEscolhida);

                    Thread.Sleep(3000);
                    Console.Clear();
                    continuarJogando();
                }
            }
        }
        // Aqui está todas palavras e onde é selecionado e codificado as palavras
       
        static void CodificarDasPalavras(string[] listaDePalavras)
        {
            Console.Clear();

            //Aqui será sorteadado as palavras
            Random paralvraAleatoria = new Random();
            int localização = paralvraAleatoria.Next(0, listaDePalavras.Length);
            string palavraEscolhida = listaDePalavras[localização];

            //Aqui iremos codificar as palavras
            string codificador = "".PadLeft(palavraEscolhida.Length, '_');
            string palavraCodificada = palavraEscolhida.Replace(palavraEscolhida, codificador);

            //Aqui vamos fazer as validações
            Validacao(palavraEscolhida, palavraCodificada);
        }

        //Aqui está o desenho da forca
        static void Desenho(int vida)
        {
            if (vida == 6)
            {
                Console.WriteLine(" _____");
                Console.WriteLine("|     |");
                Console.WriteLine("|     ");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("|");
                Console.WriteLine("|___");
            }

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

        //Aqui está a finalização do jogo, para saber se o user vai continuar jogando ou não
        static void continuarJogando()
        {
            Console.Clear();
            Console.WriteLine("Deseja continuar jogando? ");
            Console.WriteLine("1 - PARA SIM\n2 - PARA NÃO");
            Console.Write("\nSua resposta: ");
            int continuarJogando = int.Parse(Console.ReadLine());

            switch (continuarJogando)
            {
                case 1:
                    Console.WriteLine("Voltando para o menu de seleção");
                    Thread.Sleep(1000);
                    MenuSelecao();
                    break;
                case 2:
                    Console.WriteLine("Saindo da aplicação");
                    Thread.Sleep(1000);
                    Console.Clear();
                    System.Environment.Exit(2);
                    break;
                default:
                    Console.WriteLine(". . .Opção invalida. . .");
                    Console.WriteLine("Voltando para o menu de seleção");
                    Thread.Sleep(1000);
                    MenuSelecao();
                    break;
            }
        }
    }
}
