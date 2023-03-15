namespace ExerciciosAlunos;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Tanjiro jojo";
        aluno1.nota1 = 5.0;
        aluno1.nota2 = 3.0;

        aluno1.mensagem();
    }
}
