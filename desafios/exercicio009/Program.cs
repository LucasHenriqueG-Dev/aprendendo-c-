int n, m, x, cont=0;
int[] v;

System.Console.WriteLine("digite o tamanho do vetor:  ");
n = int.Parse(Console.ReadLine());
v = new int[n];
for (int i = 0; i < v.Length; i++)
{
    System.Console.WriteLine("digite os valores do vetor ");
    m = int.Parse(Console.ReadLine());
    v[i]=m;

}
System.Console.WriteLine("digite um valor para x: ");
x = int.Parse(Console.ReadLine());


for(int i=0; i <v.Length; i++)
{
    if(x== v[i])
    {
        cont++;
    }
}
System.Console.WriteLine($"o x aparece {cont} vezes");