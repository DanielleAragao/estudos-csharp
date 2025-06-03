// Questão 89 da lista: Faça um algoritmo para ler dois vetores V1 e V2 de 15 números cada. Calcular e escrever a
// quantidade de vezes que V1 e V2 possuem os mesmos números e nas mesmas posições. 

int contador = 0;
int quantidade = 0;

decimal[] vetor1 = new decimal[15];  
decimal[] vetor2 = new decimal[15];

while (contador < 15)
{
    Console.WriteLine($"Digite o {contador + 1}º número para o vetor V1:");
    vetor1[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}  

contador = 0; 
while (contador < 15)
{
    Console.WriteLine($"Digite o {contador + 1}º número para o vetor V2:");
    vetor2[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}   

contador = 0;

foreach (decimal numero1 in vetor1)
{
    if (numero1 == vetor2[contador])
    {
        quantidade++;
    }
    contador++;
}
 Console.WriteLine($"Possui {quantidade} números iguais nos vetores V1 e V2 nas mesmas posições.");