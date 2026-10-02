int  i, m,x, maior = 0, menor=0, iguais = 0, soma=0, posicao = 0;

System.Console.WriteLine("digite um valor para  M");
m = int.Parse(Console.ReadLine());

int [] v = new int [m];

for(i=0; i< v.Length ; i++){
    System.Console.WriteLine($"informe o elemento {i+1}/{m}: ");
    v[i] = int.Parse(Console.ReadLine());
}
System.Console.WriteLine("digite x: ");
x = int.Parse(Console.ReadLine());

for(i=0; i< v.Length ; i++){
    if(v[i] > x){
        maior++;
        }
    else if(v[i]< x){
        menor++;
    }
    else{
        iguais++;
    }
}
for (i = 0; i < v.Length && soma < x; i++)
{
    soma += v[i];
    posicao++;
}
    System.Console.WriteLine($"os número {maior} é a qnt de núm maiores");
    System.Console.WriteLine($"os número {menor} é a qnt de núm menores");
    System.Console.WriteLine($"os número {iguais} é a qnt de núm iguais");
    System.Console.WriteLine($"a qnt de possições para atingir x é: {posicao}");