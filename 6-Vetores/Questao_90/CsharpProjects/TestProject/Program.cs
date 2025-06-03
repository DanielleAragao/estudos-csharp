// Questão 90 da lista: Faça um algoritmo para ler um vetor de 30 números. Após isto, ler mais um número qualquer,
// calcular e escrever quantas vezes esse número aparece no vetor.

int contador = 0;
decimal[] vetor = new decimal[30];  
int quantidadeNoVetor = 0;  

while (contador < 30)
{
    Console.WriteLine($"Digite o {contador + 1}º número:");
    vetor[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}   
Console.WriteLine("Digite um número qualquer:");
decimal numeroVerificar = decimal.Parse(Console.ReadLine());

contador = 0;
foreach(decimal numero in vetor)
{
    if (numeroVerificar == numero)
    {
        quantidadeNoVetor++;
    }   
}
Console.WriteLine($"O número {numeroVerificar} aparece {quantidadeNoVetor} vezes no vetor.");


