namespace PrimeiroProjeto.TesteGPT;

public class JogoDeFutebol
{
    public int HoraInicial;
    public int HoraFinal;

    public JogoDeFutebol(int horaInicial, int horaFinal)
    {
        HoraInicial = horaInicial;
        HoraFinal = horaFinal;
    }

    public int CalcularDuracao()
    {
        int duracao;
        if (HoraInicial < HoraFinal)
        {
            duracao = HoraInicial - HoraFinal;
        }
        else
        {
            duracao = 24 - HoraInicial + HoraFinal;
        }
        return duracao;
    }
}
