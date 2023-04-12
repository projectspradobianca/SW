namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Exercício Conta Bancária - Davi dos Santos Silva - 2ºF - Etec MCM");
    Conta conta = new Conta();

    conta.nomeCliente = "Davi dos Santos";
    conta.depositar(200);
    conta.limite = 2333;
    conta.sacar(50);
    
double saldo = conta.ConsultaSaldo();
Console.WriteLine("Seu saldo é de : "+ saldo);

}
}