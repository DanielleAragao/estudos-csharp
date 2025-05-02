// Questão 16 da lista: As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
// compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
// escreva o custo total da .

Console.WriteLine("Quantas maçãs você comprou?");
int quantidadeMaça = int.Parse(Console.ReadLine());

decimal custoTotal;

if (quantidadeMaça < 12)
{
    custoTotal = (decimal) (quantidadeMaça * 1.3); 
    Console.WriteLine("o valor custo total da compra é de R$" + custoTotal);
}     
else
{
    custoTotal = quantidadeMaça * 1m;
    Console.WriteLine("o valor custo total da compra é de R$" + custoTotal);
}