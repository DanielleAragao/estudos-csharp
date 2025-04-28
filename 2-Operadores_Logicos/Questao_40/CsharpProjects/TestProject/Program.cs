// Questão 40 da lista: Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o preço
// unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total
// a pagar (total a pagar = total - desconto), sabendo-se que:
//      - Se quantidade <= 5 o desconto será de 2%
//      - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
//      - Se quantidade > 10 o desconto será de 5%

Console.WriteLine("Qual o nome do produto? ");
string nome = Console.ReadLine();

Console.WriteLine("Qual a quantidade adquirida? ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o preço da unidade? ");
decimal precoUnidade = decimal.Parse(Console.ReadLine());

decimal valorTotal = quantidade * precoUnidade;
decimal desconto;
if (quantidade <= 5)
    desconto = 0.02m * valorTotal;
else if (quantidade > 5 && quantidade <= 10)
    desconto = 0.02m * valorTotal;
else
    desconto = 0.05m * valorTotal;

decimal totalAPagar = valorTotal - desconto;
Console.WriteLine($"O valor total é de R$ {valorTotal}");
Console.WriteLine($"O desconto é de R$ {desconto}");
Console.WriteLine($"O total a pagar é de R$ {totalAPagar}");