// Questão 44 da lista: Escreva um algoritmo para ler 2 valores e se o segundo valor informado for ZERO, deve ser lido
// um novo valor, ou seja, para o segundo valor não pode ser aceito o valor zero e imprimir o resultado
// da divisão do primeiro valor lido pelo segundo valor lido. (utilizar a estrutura REPITA).

Console.WriteLine("Digite o primeiro valor: ");
decimal valor1 = decimal.Parse(Console.ReadLine());

decimal valor2;
do
{
    Console.WriteLine("Digite o segundo valor: ");
    valor2 = decimal.Parse(Console.ReadLine());
}
while (valor2 == 0);

Console.WriteLine($"A divisão do primeiro valor lido pelo segundo valor lido é: {valor1 / valor2}");




//OBS: as demais questões abaixo, que se referem à anterior, deixei em formato de comentário para não ocorrer erro.




//Questão 45 da lista: Reescreva o exercício anterior utilizando a estrutura ENQUANTO. 

// Console.WriteLine("Digite o primeiro valor: ");
// decimal valor1 = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo valor: ");
// decimal valor2 = decimal.Parse(Console.ReadLine());

// while (valor2 == 0)
// {
//     Console.WriteLine("Digite novamente um segundo valor: ");
//     valor2 = decimal.Parse(Console.ReadLine());
// }

// Console.WriteLine($"A divisão do primeiro valor lido pelo segundo valor lido é: {valor1 / valor2}");





// Questão 46 da lista: Acrescentar uma mensagem de 'VALOR INVÁLIDO' no exercício [44] caso o segundo valor
// informado seja ZERO. 

// Console.WriteLine("Digite o primeiro valor: ");
// decimal valor1 = decimal.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo valor: ");
// decimal valor2 = decimal.Parse(Console.ReadLine());

// if (valor2 == 0)
// {
//     do
//     {
//         Console.WriteLine("Valor inválido! Digite o segundo valor: ");
//         valor2 = decimal.Parse(Console.ReadLine());
//     }
//     while (valor2 == 0);
// }
// Console.WriteLine($"A divisão do primeiro valor lido pelo segundo valor lido é: {valor1 / valor2}");

