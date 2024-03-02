using System;

class Program
{
    static void Main()
    {
        string nome;
        double salarioBruto;
        double imposto;

        Console.WriteLine("Digite o nome do funcionário:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o salário bruto do funcionário:");
        while (!double.TryParse(Console.ReadLine(), out salarioBruto) || salarioBruto < 0)
        {
            Console.WriteLine("Salário inválido. Digite novamente:");
        }

        Console.WriteLine("Digite o valor do imposto:");
        while (!double.TryParse(Console.ReadLine(), out imposto) || imposto < 0)
        {
            Console.WriteLine("Valor do imposto inválido. Digite novamente:");
        }

        double salarioLiquido = salarioBruto - imposto;

        Console.WriteLine("Dados do funcionário:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido}");

        Console.WriteLine("Digite a porcentagem de aumento do salário:");
        double porcentagemAumento;

        while (!double.TryParse(Console.ReadLine(), out porcentagemAumento) || porcentagemAumento < 0)
        {
            Console.WriteLine("Porcentagem inválida. Digite novamente:");
        }


        salarioLiquido = salarioBruto - imposto;

        salarioBruto *= (1 + porcentagemAumento / 100);


        Console.WriteLine("Dados após o aumento salarial:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Salário Bruto: {salarioBruto}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido}");
    }
}