// Questão 37 da lista: Uma fruteira está vendendo frutas com a seguinte tabela de preços:
//           Até 5 Kg       |  Acima de 5 Kg
// Morango | R$ 2,50 por Kg |  R$ 2,20 por Kg
// Maçã    | R$ 1,80 por Kg |  R$ 1,50 por Kg
// Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00, receberá
// ainda um desconto de 10% sobre este total. Escreva um algoritmo para ler a quantidade (em Kg) de
// morangos e a quantidade (em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente. 


Console.WriteLine("Quantos quilos de morango você comprou?");
decimal quantMorangos = decimal.Parse(Console.ReadLine());

Console.WriteLine("Quantos quilos de maça você comprou?");
decimal quantMacas = decimal.Parse(Console.ReadLine());

decimal valorMorango;
decimal valorMaca;

if (quantMorangos <= 5)
    valorMorango = quantMorangos * 2.5m;
else
    valorMorango = quantMorangos * 2.2m;

if (quantMacas <= 5)
    valorMaca = quantMacas * 1.8m;
else
    valorMaca = quantMacas * 1.5m;

decimal valorTotal = valorMaca + valorMorango;

if ((quantMacas + quantMorangos > 8) || (valorTotal > 25))
    valorTotal = valorTotal - 0.1m * valorTotal;

Console.WriteLine("O valor a ser pago é de R$:" + valorTotal);

