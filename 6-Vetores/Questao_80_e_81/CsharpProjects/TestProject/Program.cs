// Questão 80 da lista: Ler um vetor Q de 20 posições (aceitar somente números positivos). Escrever a seguir o valor do
// maior elemento de Q e a respectiva posição que ele ocupa no vetor.

//OBS: incrementei a resposta com qual foi a posição do valor digitado.

// int contador = 0;
// decimal[] vetor = new decimal[20];
// decimal maiorValor = 0;
// int posicaoValor = 0;

// while (contador < 20)
// {
//     Console.WriteLine($"Digite o {contador + 1}º valor: ");
//     decimal entrada = decimal.Parse(Console.ReadLine());
//     while (entrada <= 0)
//     {
//         Console.WriteLine("Valor inválido. Digite um número positivo: ");
//         entrada = decimal.Parse(Console.ReadLine());
//     }

//     vetor[contador] = entrada;

//     if (vetor[contador] > maiorValor)
//     {
//         maiorValor = vetor[contador];
//         posicaoValor = contador;
//     }
//     contador++;
// }

// Console.WriteLine($"O maior valor é {maiorValor}, é o {posicaoValor + 1}º valor digitado e está na posição {posicaoValor} do vetor.");




// Questão 81 da lista: O mesmo exercício anterior, mas agora deve escrever o menor elemento do vetor e a respectiva
// posição dele nesse vetor. 

//OBS: também incrementei a resposta com qual foi a posição do valor digitado.

int contador = 0;
decimal[] vetor = new decimal[20];
decimal menorValor = decimal.MaxValue;
int posicaoValor = 0;

while (contador < 20)
{
    Console.WriteLine($"Digite o {contador + 1}º valor: ");
    decimal entrada = decimal.Parse(Console.ReadLine());
    while (entrada <= 0)
    {
        Console.WriteLine("Valor inválido. Digite um número positivo: ");
        entrada = decimal.Parse(Console.ReadLine());
    }

    vetor[contador] = entrada;
   
    if (vetor[contador] < menorValor)
    {
        menorValor = vetor[contador];
        posicaoValor = contador;
    }
    contador++;
}

Console.WriteLine($"O menor valor é {menorValor}, é o {posicaoValor + 1}º valor digitado e está na posição {posicaoValor} do vetor.");