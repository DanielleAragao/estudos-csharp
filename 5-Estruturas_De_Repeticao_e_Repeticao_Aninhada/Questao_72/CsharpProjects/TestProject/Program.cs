// Questão 72 da lista: Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever:
// - o maior preço lido
// - a média aritmética dos preços dos produtos


int contador;
bool valorValido;
decimal valor = 0;
decimal maiorValor = 0; 
decimal somaValor = 0;

for (contador = 1; contador < 16 ; contador++)
{
    valorValido = false; 
    
    Console.WriteLine($"Digite o preço do {contador}º produto: ");
    string entrada = Console.ReadLine(); 

    while (!valorValido)
    {
        if (decimal.TryParse(entrada, out valor) && valor > 0)
        {
            valorValido = true;
        }
        else
        {
            Console.WriteLine($"Valor inválido. Digite o preço do {contador}º produto: ");
            entrada = Console.ReadLine(); 
        }
    }
    
    somaValor += valor;

    if (valor > maiorValor)
    {
        maiorValor = valor;
    }
}
decimal media = somaValor / 15m;

Console.WriteLine($"O maior preço é: {maiorValor}");
Console.WriteLine($"A média dos preços é: {media:F2}");