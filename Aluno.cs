using System;

class Aluno{
    private string nome;
    private double n1, n2, n3;

    public Aluno(string nome, double n1, double n2, double n3){
        this.nome = nome;
        this.n1 = n1;
        this.n2 = n2;
        this.n3 = n3;
    }

    public string getNome(){
        return nome;
    }

    public double getN1(){
        return n1;
    }

    public double getN2(){
        return n2;
    }

    public double getN3(){
        return n3;
    }

    public void setNome(string nome){
        this.nome = nome;
    }

    public void setN1(double n1){
        this.n1 = n1;
    }

    public void setN2(double n2){
        this.n2 = n2;
    }

    public void setN3(double n3){
        this.n3 = n3;
    }

    public double calcularMedia(){
        double media = (n1 + n2 +n3) /3;
        Console.WriteLine("A média do aluno {0} é: {1}", getNome(), media);

        return media;
    }

    public void obterSituacao(){
        double media = calcularMedia();

        if(media >= 7){
            Console.WriteLine("O aluno {0} foi aprovado!", getNome());
        } else if(media >= 6){
            Console.WriteLine("O aluno {0} ficou de exame!", getNome());
        } else Console.WriteLine("O aluno {0} foi reprovado!", getNome());
    
    }
}