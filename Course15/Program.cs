using System.Globalization;

//Exercício 1
/*
Console.Write("Digite um número: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
*/

//Exercício 2
/*
Console.Write("Digite quantos números você deseja avaliar: ");
int n = int.Parse(Console.ReadLine());

int nIn = 0;
int nOut = 0;

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (x >=10 && x <= 20)
    {
        nIn = nIn + 1;
    }
    else
    {
        nOut = nOut + 1;
    }
}

Console.WriteLine($"{nIn} in");
Console.WriteLine($"{nOut} out");
*/

//Exercício 3
/*
Console.Write("Digite quantos testes você deseja realizar: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    double x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    double x = ((x1 * 2) + (x2 * 3) + (x3 * 5)) / 10;

    Console.WriteLine($"Teste #{i + 1}: " +x.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine(" ");
}
*/

//Exercício 4
/*
Console.Write("Digite quantos testes você deseja realizar: ");
int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    Console.WriteLine(" ");
    Console.Write("Digite os valores: ");
    string[] valores = Console.ReadLine().Split(' ');
    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);

    if (b == 0)
    {
        Console.WriteLine("Divisão impossível");
    }
    else
    {
        double resultado = (a / b);
        Console.WriteLine("Resultado: " + resultado.ToString("F1", CultureInfo.InvariantCulture));
    }
}
*/

//Exercício 5
/*
Console.Write("Digite o número fatorial: ");
int n = int.Parse(Console.ReadLine());


int fat = 1;
for (int i = 1; i <= n; i++)
{
        fat = fat * i;
}
Console.WriteLine(fat);
*/

//Exercício 6
/*
Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}
*/

//Exercício 7
/*
Console.Write("Digite quantos testes você deseja realizar: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    int x = 0 + i;
    int y = (int)Math.Pow(x, 2);
    int z = (int)Math.Pow(x, 3);
    Console.WriteLine($"{x} {y} {z}") ;
}
*/