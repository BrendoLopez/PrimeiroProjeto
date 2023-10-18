namespace PrimeiroProjeto
{
    public class Banco
    {
        private int _numeroConta;
        private string _nomeTitular;
        private double _saldoInicial;

        public Banco()
        {
        } 
        public Banco(int numeroConta, string nomeTitular, double saldoInicial) : this() { }

        public void SetNomeTitular(string nome)
        {
            _nomeTitular = nome;
        }
        public int GetNumeroConta()
        {
            return _numeroConta;
        }
        public double GetSaldoInicial()
        {
            return _saldoInicial;
        }
    }
}
