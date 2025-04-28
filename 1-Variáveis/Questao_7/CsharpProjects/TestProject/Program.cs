// Questão 7 da lista: Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade
// dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias. 

Console.WriteLine("Digite abaixo a sua idade: ");
Console.WriteLine("Quantos anos?");
int ano = int.Parse(Console.ReadLine());

Console.WriteLine("Meses?");
int meses = int.Parse(Console.ReadLine());

Console.WriteLine("Dias?");
int dias = int.Parse(Console.ReadLine());

ano = ano * 365;
meses = meses * 30;

Console.WriteLine($"Sua idade expressa em dias é de: {ano + meses + dias}");
