using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_conta_bancaria
{
    public class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) : this(conta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia;

            Saldo = Saldo -5;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $ " 
                + Saldo;
        }
    }
}
