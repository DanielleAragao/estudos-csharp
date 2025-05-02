// Questão 24 da lista: Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendo-se que
// ele recebe uma comissão de 3% sobre o total das vendas até R$ 1.500,00 mais 5% sobre o que
// ultrapassar este valor, calcular e escrever o seu salário total. 

Console.WriteLine("Qual o seu salário fixo? ");
decimal salarioFixo = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor das vendas que você efetuou?");
decimal valorVendas = decimal.Parse(Console.ReadLine());

decimal salarioTotal;

if (valorVendas <= 1500)
{
salarioTotal = salarioFixo + (0.03m * valorVendas);
Console.WriteLine($"Salário Total: R${salarioTotal}");  
}
else
{
    salarioTotal = (1500m * 0.03m) + (0.05m * (valorVendas - 1500m)) + salarioFixo;
    Console.WriteLine($"Salário Total: R${salarioTotal}");      
}


