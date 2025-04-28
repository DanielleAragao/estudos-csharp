// Questão 9 da lista: Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
// Calcular e escrever o valor do novo salário. 

Console.WriteLine("Qual o seu salário mensal? ");
decimal salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o percentual de reajuste?");
decimal reajuste = decimal.Parse(Console.ReadLine());

decimal novoSalario = ((salario * reajuste)/100) + salario;
Console.WriteLine("Seu novo salário será: " + novoSalario); 