using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] menuOptions = { "Play Game", "Instructions", "Exit" };
        int selectedIndex = 0;

        do
        {
            Console.Clear();
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }
                Console.WriteLine($"  << {menuOptions[i]} >>  ");
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                selectedIndex = (selectedIndex - 1 + menuOptions.Length) % menuOptions.Length;
                break;

                case ConsoleKey.DownArrow:
                selectedIndex = (selectedIndex + 1) % menuOptions.Length;
                break;

                //Lógica do jogo
                case ConsoleKey.Enter:

                if (selectedIndex == 0)
                {
                    Console.Clear();
                    Console.Write("O jogo está começando! \nMas antes de começarmos, nos diga o seu Nickname: ");
                    string nickNamePlayer = Console.ReadLine();

                    bool opcaoEscolhida = false;
                    string[] temaJogo = { "Futebol", "Filmes", "Séries", "Jogos Online", "Guerras" };
                    int selecionarTemaJogo = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"{nickNamePlayer}, escolha o tema do jogo abaixo.");
                        Console.WriteLine();

                        for (int i = 0; i < temaJogo.Length; i++)
                        {
                            if (i == selecionarTemaJogo)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                            }
                            Console.WriteLine($"  << {temaJogo[i]} >>  ");
                            Console.ResetColor();
                        }

                        ConsoleKeyInfo teste = Console.ReadKey();
                        switch (teste.Key)
                        {
                            case ConsoleKey.UpArrow:
                            selecionarTemaJogo = (selecionarTemaJogo - 1 + temaJogo.Length) % temaJogo.Length;
                            break;

                            case ConsoleKey.DownArrow:
                            selecionarTemaJogo = (selecionarTemaJogo + 1) % temaJogo.Length;
                            break;

                            case ConsoleKey.Enter:
                            opcaoEscolhida = true;
                            if (selecionarTemaJogo == 0)
                            {
                                Console.Clear();
                                Console.WriteLine($"{nickNamePlayer}, você escolheu o tema: <<{temaJogo[0]}>>");
                                Console.WriteLine("Para este tema, temos a seguinte questão: QUAL JOGADOR DE FUTEBOL MARCOU 23 GOLS EM UM ÚNICO JOGO, COM APENAS 13 ANOS? ");
                                Console.Write("Resposta: ");
                                string resposta = Console.ReadLine();

                                while (resposta != temaJogo[0])
                                {
                                    Console.WriteLine("Você errou!");
                                    resposta = Console.ReadLine();
                                }
                            }
                            continue;
                        }
                    } while (!opcaoEscolhida);
                    Console.ReadKey();
                }
                else if (selectedIndex == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Instruções do jogo...");
                    Console.WriteLine("");
                    Console.WriteLine("É um jogo bem simples, onde você tem apenas 10 tentativas para acertar.");
                    Console.WriteLine("As palavras serão aleatórias e haverá uma dica inicial, boa sorte!");
                    Console.ReadKey();
                }
                else if (selectedIndex == 2)
                {
                    Console.WriteLine("Você saiu do jogo! \nAté a próxima.");
                    return;
                }
                break;
            }
        } while (true);
    }
}