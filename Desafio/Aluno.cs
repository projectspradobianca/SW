namespace Desafio;
class Aluno
{
    public string nome(){ 
        Console.Write("Digite o nome do aluno: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Aluno: "+ nome);
        return nome;
    }
    
      //media
     public double notas(){
         Console.Write("Digite a sua nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A nota digitada foi: "+ nota1);
        Console.Write("Digite a sua nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A nota digitada foi: "+ nota2);
        return (nota1+nota2)/2;
    }
    
  
    
    //situação (APROVADO/REPROVADO)
    public string obterSituacao(double media){
        string situacao = "";
        if(media>=6){
            situacao ="Aprovado";
        }else{
            situacao ="Reprovado";
        }
        return situacao;    
    } 
    

    //mensagem
    public void mensagem(){
        string nome1 = nome();
        double mediaCalculada = notas();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+ " está "+resultadoSituacao+" com média "+mediaCalculada);
    }
}