// Questão 86: Faça um algoritmo para ler 10 números e armazenar em um vetor. Após isto, o algoritmo deve
// ordenar os números no vetor em ordem crescente. Escrever o vetor ordenado.

int contador = 0;
decimal[] vetor =  new decimal[10];

while (contador < 10)
{
    Console.WriteLine($"Digite o {contador + 1}º número: ");
    decimal numero = decimal.Parse(Console.ReadLine());
    vetor[contador] = numero;
    contador++;    
}

Array.Sort(vetor);


foreach (decimal numero in vetor)
{
    Console.WriteLine(numero);
}



// Questão 87: O mesmo exercício anterior, mas depois de ordenar os elementos do vetor em ordem crescente,
// deve ser lido mais um número qualquer e inserir esse novo número na posição correta, ou seja,
// mantendo a ordem crescente do vetor. 

//OBS: preferi fazer a resolução desse exercício usando uma lista, pois o vetor tem tamanho fixo.

// List <decimal> numeros = new List<decimal>();

// while (numeros.Count < 10)
// {
//     Console.WriteLine($"Digite o {numeros.Count + 1}º número: ");
//     decimal numero = decimal.Parse(Console.ReadLine());
//     numeros.Add(numero);    
// }

// numeros.Sort();

// Console.WriteLine("Digite outro valor:");
// decimal novoNumero = decimal.Parse(Console.ReadLine());
// numeros.Add(novoNumero);

// numeros.Sort();

// foreach (decimal numero in numeros)
// {
//     Console.WriteLine(numero);
// }