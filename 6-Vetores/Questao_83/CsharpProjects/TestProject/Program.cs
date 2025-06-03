// Questão 83 da lista: Faça um algoritmo para ler 20 números e armazenar em um vetor. Após a leitura total dos 20
// números, o algoritmo deve escrever esses 20 números lidos na ordem inversa. 

int contador = 0;
decimal[] numeros = new decimal[20];

while (contador < 20)
{
    Console.WriteLine($"Digite o {contador + 1}º número: ");
    decimal numero = decimal.Parse(Console.ReadLine()); 
    numeros[contador] = numero;
    contador++;   
}

foreach (decimal numero in numeros.Reverse())
{
    Console.WriteLine(numero);
}
