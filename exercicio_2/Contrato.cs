namespace exercicio_2;
class Contrato
{
   public string? nome {get;set;}

   public virtual string Email(){
    return "Email: ";
   }

   public virtual string Telefone(){
    return "Telefone: ";

    public string MostraDados(){
        console.Writeline("Nome: "+ this.nome);
        console.Writeline("Email: "+this.Email);
        console.Writeline("Telefone: "+this.Telefone);
    }
   }
}
