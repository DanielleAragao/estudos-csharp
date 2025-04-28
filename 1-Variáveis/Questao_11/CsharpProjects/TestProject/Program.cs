// Questão 11 da lista: Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês,
// mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele
// efetuadas. Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas
// vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do
// vendedor. 

Console.WriteLine("Qual o número de carros vendidos por você? ");
int numCarros = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor total de suas vendas?");
decimal valorVendas = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu salário fixo? ");
decimal salarioFixo = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor que você recebe por carro vendido?");
decimal valorPorCarro = decimal.Parse(Console.ReadLine());

decimal salarioFinal = salarioFixo + (valorPorCarro * numCarros)  + (0.05m * valorVendas);
Console.WriteLine($"O valor do seu salário final é: {salarioFinal}");

