// Questão 82 da lista: Ler um vetor A de 10 números. Após, ler mais um número e guardar em uma variável X.
// Armazenar em um vetor M o resultado de cada elemento de A multiplicado pelo valor X. Logo após,
// imprimir o vetor M. 

//OBS: incrementei a resolução para que os valores  do vetor M fossem exibidos com sua respectiva posição.

int contador = 0;
decimal[] vetorA = new decimal[10];
decimal[] M = new decimal[10];

while (contador < 10)
{
    Console.WriteLine($"Digite o {contador + 1}º número:");
    vetorA[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}
Console.WriteLine("Digite o número que irá multiplicar o vetor:");
decimal x = decimal.Parse(Console.ReadLine());


for (contador = 0; contador < vetorA.Length; contador++)
{
     M[contador] = vetorA[contador] * x;
    Console.WriteLine($"O {contador + 1}º valor de M é: {M[contador]} e está na posição {contador} do vetor.");
}
