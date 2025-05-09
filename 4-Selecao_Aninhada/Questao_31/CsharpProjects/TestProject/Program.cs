// Questão 31 da lista: Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e escrever se formam
// ou não um triângulo. OBS: para formar um triângulo, o valor de cada lado deve ser menor que a soma
// dos outros 2 lados. 

Console.WriteLine("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor: ");
int valor3 = int.Parse(Console.ReadLine());

if ((valor1 < (valor2 + valor3)) && (valor2 < (valor1 + valor3)) && (valor3 < (valor1 + valor2)))
    Console.WriteLine($"Os lados {valor1}, {valor2}, {valor3} formam um triângulo.");

else
    Console.WriteLine($"Os lados {valor1}, {valor2}, {valor3} não formam um triângulo.");