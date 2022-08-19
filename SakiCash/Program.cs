


using System;

namespace SakiCash {

    class Program {

        static void Main(string[] args) {

            ItensConta dadosConta;

            Console.WriteLine();
            Console.Write("Digite o numero da conta => ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta => ");
            string titular = Console.ReadLine();
            Console.WriteLine();


            Console.Write("Deseja digitar o depoisito inicial S/N?: ");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S" ) {
                Console.WriteLine();
                Console.Write("Digite o valor que deseja depositar: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.WriteLine();
                dadosConta = new ItensConta (conta, titular, saldo);
            }
            else {
                dadosConta = new ItensConta(conta, titular);
            }


            Console.WriteLine();
            Console.WriteLine(dadosConta);

            Console.WriteLine();
            Console.Write("Digite um valor para déposito: ");
            double deposito = double.Parse(Console.ReadLine());
            dadosConta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("O saldo da conta foi atualizado :)");
            Console.WriteLine(dadosConta);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            deposito = double.Parse(Console.ReadLine());
            dadosConta.Saque(deposito);
            Console.WriteLine();
            Console.WriteLine("O saldo da conta foi atualizado :)");
            Console.WriteLine(dadosConta);

            Console.WriteLine();

        }


    }

}
