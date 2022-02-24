using System;
   
class Aula03{

    static void Main(){// declaração de variáveis locais 
        byte n1 = 10; //0 e 255
        int num1, num2, res;
        num1=10;
        num2=4;
        res = num1+num2;
        //char letra = 'R';
        //float valor =3.5f;
        string nome  = "Roger";

        //var aux= 10;// quando uso operador var nao estou declarando o tipo: Aqui nao se especifica o tipo
        //var aux="Rogerio Tiago ";
        var aux= nome;

        Console.WriteLine(" O nome do Aluno é: " +aux+ "...");
        Console.WriteLine("A soma de" +num1+" mais " +num2+ "é igual a: " +res);


    }
}
