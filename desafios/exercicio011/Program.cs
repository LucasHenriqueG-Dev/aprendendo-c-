// Faça um programa em C# para percorrer um vetor V de números inteiros e verificar quantas
// vezes um determinado valor x está presente no vetor. O valor de x deve ser informado pelo
// usuário. Considere que o vetor já foi criado e preenchido.

int [] v = {12, 123, 123, 32,4 ,4};
int x, cont = 0;

System.Console.WriteLine("digite o valor de x: ");
x = int.Parse(Console.ReadLine());

for(int i = 0; i < v.Length; i++)
{
    if (v[i] == x)
    {
        cont++;
    }
}

if (cont == 0)
{
    System.Console.WriteLine($"o {x} não aparece no vetor");
}
else
{
    System.Console.WriteLine($"o {x} aparece {cont} vezes no vetor");
}
