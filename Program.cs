using System;

class Program{
    public static void Main(){
        int opcao = 0;

        Console.WriteLine("===========================");
        Console.WriteLine("Olá! Seja bem vindo ao C#!");
        Console.WriteLine("===========================");

        while(opcao != 5){
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("[1] Jogo da adivinhação");
            Console.WriteLine("[2] Calcular IMC");
            Console.WriteLine("[3] Tabuada");
            Console.WriteLine("[4] Escola");
            Console.WriteLine("[5] Sair");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao){
                case 1:
                Jogo();
                break;
                case 2:
                Imc();
                break;
                case 3:
                Tabuada();
                break;
                case 4:
                Escola();
                break;
                case 5:
                Console.WriteLine("Você encerrou o programa!");
                break;
                default: Console.WriteLine("Opção inválida, digite novamete!");
                break;
            } 
        }
    }
    public static void Jogo(){
        Random random = new Random();

        int aleatorio = random.Next(0, 100);
        int chute = -1;
        
        while(chute != aleatorio){
            Console.WriteLine("Tente adivinhar o número sorteado!");
            chute = int.Parse(Console.ReadLine()!);

            if(chute > aleatorio) {
                Console.WriteLine("O número sorteado é menor que {0}", chute);
            } else if (chute < aleatorio){
                Console.WriteLine("O número sorteado é maior que {0}", chute);
            } else Console.WriteLine("Parabéns! Você adivinhou o número sorteado: "+ aleatorio);
        }
    }
    public static void Imc(){
        double peso;
        double altura;

        Console.WriteLine("Digite seu peso: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine()!);

        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: {0}!", imc);
    }
    public static void Tabuada(){
        int num;

        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine()!);

        Console.WriteLine("A tabuada do número {0} é: ",num);
        for(int i = 1; i <= 10; i++){
            Console.WriteLine(num * i);
        }
    }
    public static void Escola(){
        string nome;
        double n1, n2, n3;

        Console.WriteLine("Digite o nome do aluno: ");
        nome = Console.ReadLine()!;
        Console.WriteLine("Digite a primeira nota: ");
        n1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a segunda nota: ");
        n2 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a terceira nota: ");
        n3 = double.Parse(Console.ReadLine()!);

        Aluno aluno = new Aluno(nome, n1, n2, n3);
        
        aluno.obterSituacao();
    }  
}