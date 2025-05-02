// Questão 14 da lista: Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso
// contrário escrever NÃO É MAIOR QUE 10! 

//OBS: incrementei a resposta adicionando a condição para quando o valor for igual a 10.

Console.WriteLine("Qual o valor?");
decimal valor= decimal.Parse(Console.ReadLine());

if (valor > 10)
    Console.WriteLine("É MAIOR QUE 10!");

else if (valor == 10)
    Console.WriteLine("É IGUAL A 10!");
else
    Console.WriteLine("NÃO É MAIOR QUE 10!");


