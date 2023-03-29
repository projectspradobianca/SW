namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();

        //p1.Nome = "parafuso";
        p1.AlteraNome("Parafuso");
        //p1.Preco = 1.67;
        p1.AlteraPreco(1.98);

        p1.MostraDados();
    }
}
