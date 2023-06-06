using ExceptionEx.Entities;
using ExceptionEx.Entities.Exceptions;

try
{
    Console.WriteLine("Informe os dados da conta:");
    Console.Write("Número: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Titular: ");
    string holder = Console.ReadLine();

    Console.Write("Saldo inicial: ");
    double balance = double.Parse(Console.ReadLine());

    Console.Write("Limite de saque: ");
    double withdrawLimit = double.Parse(Console.ReadLine());

    Account account = new(number, holder, balance, withdrawLimit);

    Console.Write("Informe a quantia que deseja sacar: ");
    double withdraw = double.Parse(Console.ReadLine());

    account.Withdraw(withdraw);

    Console.WriteLine($"Novo saldo: {account.Balance:F2}");
}
catch (DomainException e)
{
    Console.WriteLine($"Erro: {e.Message}");
}
