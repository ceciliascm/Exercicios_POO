namespace Exercicios_POO;

/*Exercício: Criando a Classe "ContaBancaria"
Objetivo: Criar uma classe chamada "ContaBancaria" para simular operações bancárias básicas.
Requisitos:
Crie uma classe chamada ContaBancaria.
A classe ContaBancaria deve ter os seguintes atributos (campos):
accountNumber (string): O número da conta bancária.
name (string): O nome do titular da conta.
bankBalance (decimal): O saldo atual da conta (inicialmente zero).
A classe ContaBancaria deve ter um construtor que receba o número da conta e o nome do titular como parâmetros e os inicialize. O bankBalance deve ser inicializado como zero.

Crie um método chamado Deposit(decimal value) que adicione o value especificado ao bankBalance da conta. O método deve imprimir uma mensagem confirmando o depósito:
Depósito de [value] realizado com sucesso. Novo bankBalance: [bankBalance atual].

Crie um método chamado Withdraw(decimal value) que subtraia o value especificado do bankBalance da conta. O método deve verificar se o bankBalance é suficiente antes de realizar o saque. Se o bankBalance for insuficiente, o método deve imprimir uma mensagem de erro e não realizar o saque. Se o saque for realizado com sucesso, o método deve imprimir uma mensagem confirmando o saque:
bankBalance suficiente:
Saque de [value] realizado com sucesso. Novo bankBalance: [bankBalance atual].
bankBalance insuficiente:
bankBalance insuficiente para realizar o saque. bankBalance atual: [bankBalance atual].

     6. Crie um método chamado ShowBankBalance() que imprima o bankBalance atual da conta:
bankBalance atual da conta [número da conta]: [bankBalance atual].

      7. No método Main do seu programa, crie um objeto da classe ContaBancaria, fornecendo o número da conta e o nome do titular.

      8. Realize as seguintes operações na conta bancária:
Deposite um value inicial.
Saque um value (dentro do limite do bankBalance).
Tente Withdraw um value maior que o bankBalance disponível (para testar a mensagem de erro).
Exiba o bankBalance atual da conta.*/

using System;

class BankAccount
{
    public String accountNumber;
    public String name;
    public double bankBalance = 0;

    public BankAccount(String accountNumber, String name)
    {
        this.accountNumber = accountNumber;
        this.name = name;
    }

    public void Deposit(double value)
    {
        if (value > 0)
        {
            Console.WriteLine($"Depósito de {value} realizado com sucesso. Saldo atual: {this.bankBalance += value}");
        }
        else
        {
            Console.WriteLine("Número inválido");
        }
    }

    public void Withdraw(double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Número inválido");
        }
        else if (this.bankBalance < value)
        {
            Console.WriteLine($"Saldo insuficiente para realizar o saque. Saldo atual: {this.bankBalance}.");
        }
        else
        {
            Console.WriteLine(
                $"Saldo suficiente: \nSaque de {value} realizado com sucesso. Novo saldo: {this.bankBalance -= value}.");
        }

    }

    public void ShowBankBalance()
    {
        Console.WriteLine($"Saldo atual da conta {accountNumber}: {bankBalance}.");
    }
}
    
