

namespace SakiCash {
    internal class ItensConta {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ItensConta() { }

        public ItensConta(int conta, string titular) {
            Conta = conta;
            Titular = titular;
        }

        public ItensConta(int conta, string titular, double depositoInicial):this(conta, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        override public string ToString() {
            Console.WriteLine();
            Console.WriteLine("DADOS DA CONTA");
            Console.WriteLine($"Conta: {Conta}");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: {Saldo.ToString("f2")} R$ Dinheiros");
            return $"";
        }

    }
}
