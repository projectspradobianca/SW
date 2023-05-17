namespace exercicio_2;
class PessoaFisica:Contrato
{
   public string Cpf(){
    return "666.666.666-66"
   }

   public int Idade(){
    return "Idade: ";
   }

   public virtual string Email(){
    return base.Email()+"camposbiancapp@gmail.com";
   }


}
