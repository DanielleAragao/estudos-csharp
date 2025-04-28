// Questão 6 da lista: Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
// área do retângulo. 

Console.WriteLine("Digite o valor da base: ");
int Base = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da altura: ");
int Altura = int.Parse(Console.ReadLine());

int Resultado= Base * Altura;
Console.WriteLine($"A área do retângulo é = {Resultado}");
