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
            Console.Clear(); // Limpa o console para redesenhar o menu

            // Exibe as opções do menu com destaque na opção selecionada
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow; // Cor do texto destacado
                    Console.BackgroundColor = ConsoleColor.DarkBlue; // Cor de fundo destacada
                }

                Console.WriteLine($"  << {menuOptions[i]} >> ");

                // Resetar as cores para as configurações padrão
                Console.ResetColor();
            }

            // Aguarda a entrada do usuário
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            // Atualiza o índice selecionado com base na tecla pressionada
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                selectedIndex = (selectedIndex - 1 + menuOptions.Length) % menuOptions.Length;
                break;

                case ConsoleKey.DownArrow:
                selectedIndex = (selectedIndex + 1) % menuOptions.Length;
                break;

                case ConsoleKey.Enter:
                if (selectedIndex == 0)
                {
                    Console.Clear(); // Limpa o console antes de começar o jogo
                    Console.WriteLine("O jogo está começando!");
                        // Adicione aqui a lógica do seu jogo
                        Console.WriteLine("Teste");
                        // Pode ser uma chamada para uma função que contém a lógica do jogo
                        // ou você pode incluir a lógica diretamente aqui
                        Console.ReadKey(); // Aguarda uma tecla antes de retornar ao menu
                }
                else if (selectedIndex == 1)
                {
                    Console.Clear(); // Limpa o console antes de exibir as instruções
                    Console.WriteLine("Instruções do jogo...");
                        Console.WriteLine("");
                        Console.WriteLine("É um jogo bem simples, onde você tem apenas 10 tentativas para acertar.");
                        Console.WriteLine("As palavras serão aleatórias e haverá uma dica inicial, boa sorte!");
                        Console.ReadKey(); // Aguarda uma tecla antes de retornar ao menu
                }
                else if (selectedIndex == 2)
                {
                        Console.WriteLine("Você saiu do jogo! \nAté a próxima.");
                        // Adicione aqui a lógica de saída do programa se o usuário selecionar "Exit"
                        return;
                }
                break;
            }
        } while (true);
    }
}