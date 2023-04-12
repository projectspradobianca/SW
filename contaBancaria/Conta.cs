

namespace conta_bancaria;

class Conta

{ 

    public string? nomeCliente{get;set;}
    public int numeroConta {get;set;}
    private double saldo{get;set;}
    public double limite {get;set;}


//realizar depósito
    public void depositar (double valor){
        this.saldo += valor;
    }

//realizar saque
public void sacar (double valor){
    this.saldo -= valor;
}

//realizar consulta
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}   