// Questão 68 da lista: Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo
// que permita a entrada das seguintes informações: a) o número total de mercadorias no estoque; b) o
// valor de cada mercadoria. Ao final imprimir o valor total em estoque e a média de valor das
// mercadorias.

// Console.WriteLine("Qual o número total de mercadorias no estoque?");
// int quantidadeDeMercadorias = int.Parse(Console.ReadLine());

// int contador = 1;
// decimal valorTotal = 0;

// while (contador < quantidadeDeMercadorias + 1)
// {
//     Console.WriteLine($"Qual o valor da mercadoria {contador}?");
//     decimal valor = decimal.Parse(Console.ReadLine());
//     valorTotal = valorTotal + valor;
//     contador++;
// }

// decimal media = valorTotal / quantidadeDeMercadorias;
// Console.WriteLine("O valor total em estoque é de R$" + valorTotal + " e a média de valor das mercadorias é de R$" + media);



// Questão 69 da lista: O mesmo exercício anterior, mas agora não será informado o número de mercadorias em estoque.
// Então o funcionamento deverá ser da seguinte forma: ler o valor da mercadoria e perguntar ‘MAIS
// MERCADORIAS (S/N)?’. Ao final, imprimir o valor total em estoque e a média de valor das
// mercadorias em estoque. 

//OBS: incrementei a resolução para os casos de se digitar uma palavra diferente de "n" ou "s",
//se digitar número negativo ou zero no valor da mercadoria e se digitar uma palavra em vez do valor.

string resposta = "S";
int quantidadeDeMercadorias = 0;
decimal valorTotal = 0;

while (resposta == "S")
{
    decimal valor = 0;
    bool valorValido = false;

    while (!valorValido)
    {
        Console.WriteLine($"Qual o  valor da mercadoria? ");
        string valorMercadoria = Console.ReadLine();

        if (decimal.TryParse(valorMercadoria, out valor) && valor > 0)
        {
            valorValido = true;
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um valor válido para a mercadoria: ");
        }
    }

    valorTotal = valorTotal + valor;
    quantidadeDeMercadorias++;

    Console.WriteLine("Deseja adicionar mais mercadorias? (S/N)");
    resposta = Console.ReadLine().ToUpper();

    while (resposta != "S" && resposta != "N")
    {
        Console.WriteLine("Resposta inválida. Deseja adicionar mais mercadorias? (S/N)");
        resposta = Console.ReadLine().ToUpper();
    }
}

decimal media = (decimal)valorTotal / quantidadeDeMercadorias;
Console.WriteLine($"O valor total é de: {valorTotal} ");
Console.WriteLine($"A média é de: {media}");



