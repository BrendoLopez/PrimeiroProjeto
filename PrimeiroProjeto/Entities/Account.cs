namespace PrimeiroProjeto.Entities;

internal class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

    public Account()
    {
    }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public void Withdraw(double amount)
    {
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public override string ToString()
    {
        return "Número: " + Number 
            + "\nTitular: " + Holder 
            + "\nSaldo: " + Balance;
    }
}
