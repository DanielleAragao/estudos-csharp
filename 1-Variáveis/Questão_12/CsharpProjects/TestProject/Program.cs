// Questão 12 da lista: Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor
// correspondente em graus Celsius.

//OBS: aprimorei a resposta acrescentando a exibição do valor final arredondado para o número par mais próximo.

Console.WriteLine("Qual a temperatura em fahrenheit?");
double tempFahrenheit = double.Parse(Console.ReadLine());

double tempCelsius = (5 *(tempFahrenheit-32))/9;
double tempCelsiusArredondado = Math.Round (tempCelsius,2);

Console.WriteLine("O valor em graus Celsius é: " + tempCelsius);
Console.WriteLine("O valor em graus Celsius arredondado é: " + tempCelsiusArredondado);