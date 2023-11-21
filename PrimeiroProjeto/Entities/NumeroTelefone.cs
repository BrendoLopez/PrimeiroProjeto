namespace PrimeiroProjeto.Entities;

public class NumeroTelefone
{
    public int Ddd{ get; set; }

    public NumeroTelefone()
    {
    }

    public NumeroTelefone(int ddd)
    {
        this.Ddd = ddd;
    }

    public void ChecarDdd()
    {
        if (Ddd == 61)
        {
            Console.WriteLine("Brasilia");
        }
        else if (Ddd == 71)
        {
            Console.WriteLine("Salvador");
        }
        else if (Ddd == 11)
        {
            Console.WriteLine("Sao Paulo");
        }
        else if (Ddd == 21)
        {
            Console.WriteLine("Rio de Janeiro");
        }
        else if(Ddd == 32)
        {
            Console.WriteLine("Juiz de Fora");
        }
        else if (Ddd == 19)
        {
            Console.WriteLine("Campinas");
        }
        else if (Ddd == 27)
        {
            Console.WriteLine("Vitoria");
        }
        else if (Ddd == 31)
        {
            Console.WriteLine("Belo Horizonte");
        }
        else
        {
            Console.WriteLine("DDD nao cadastrado");
        }

        NumeroTelefone numeroTelefone = new NumeroTelefone();
        numeroTelefone.Ddd = int.Parse(Console.ReadLine());
        numeroTelefone.ChecarDdd();
    }
}
