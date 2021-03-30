namespace Classes
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta() { }

        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}