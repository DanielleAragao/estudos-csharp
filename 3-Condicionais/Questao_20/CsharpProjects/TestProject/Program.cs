//Questão 20 da lista: Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem crescente.

//OBS: incrementei a resposta considerando que poderão ser digitados números iguais e qual a exibição correspondente para caso isso ocorra.

Console.WriteLine("Digite o primeiro valor: ");
decimal valor1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
decimal valor2 = decimal.Parse(Console.ReadLine());

if (valor1 != valor2)
 if (valor1 > valor2)
 Console.WriteLine($"{valor2}, {valor1}");
 else
   Console.WriteLine($"{valor1}, {valor2}"); 
else
Console.WriteLine("Os valores são iguais. ");