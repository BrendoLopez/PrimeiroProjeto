class Program
{
    static void DesenharForca(int erros)
    {
        Console.WriteLine("  +---+");
        Console.WriteLine("  |   |");

        switch (erros)
        {
            case 0:
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            break;
            case 1:
            Console.WriteLine("  O   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            break;
            case 2:
            Console.WriteLine("  O   |");
            Console.WriteLine("  |   |");
            Console.WriteLine("      |");
            break;
            case 3:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|   |");
            Console.WriteLine("      |");
            break;
            case 4:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("      |");
            break;
            case 5:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" /    |");
            break;
            case 6:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" / \\  |");
            break;
        }

        Console.WriteLine("      |");
        Console.WriteLine("=========");
    }
    static void Main()
    {
        int erros = 6;
        DesenharForca(erros);
    }
}