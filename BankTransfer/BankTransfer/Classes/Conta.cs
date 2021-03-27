using BankTransfer.Enums;
using System;

namespace BankTransfer.Classes
{
    public class Conta
    {
        public Conta(string nome, double saldo, double credito, TipoConta tipoConta)
        {
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
            TipoConta = tipoConta;
        }

        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private TipoConta TipoConta { get; set; }


        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta é de: ", Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo = +valorDeposito;
            Console.WriteLine("Saldo atuel da conta é de: ", Saldo);
        }

        public void Transferencia (double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + TipoConta + " | ";
            retorno += "Nome " + Nome + " | ";
            retorno += "Saldo " + Saldo + " | ";
            retorno += "Crédito " + Credito;
            return retorno;
        }
    }
}
