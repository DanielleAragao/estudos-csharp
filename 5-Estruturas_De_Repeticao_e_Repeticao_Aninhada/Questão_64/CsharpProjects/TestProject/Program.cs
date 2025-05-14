// Questão 64 da lista: Escreva um algoritmo para ler 10 números. Todos os números lidos com valor inferior a 40 devem
// ser somados. Escreva o valor final da soma efetuada. 

int contador = 1;
decimal soma = 0;

while (contador < 11)
{
    Console.WriteLine($"Digite o {contador}° número: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    if (valor <= 40)
        soma = soma + valor;

    contador++;
}
Console.WriteLine("O valor final da soma é: " + soma);

