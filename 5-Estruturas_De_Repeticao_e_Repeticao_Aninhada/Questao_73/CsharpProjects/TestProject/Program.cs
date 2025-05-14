// Questão 73 da lista: A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos
// para coletar dados sobre o salário e número de filhos de cada habitante e após as leituras, escrever:
// a) Média de salário da população
// b) Média do número de filhos
// c) Maior salário dos habitantes
// d) Percentual de pessoas com salário menor que R$ 150,00
// Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”.

//OBS: incrementei a resposta com a não permissão de valores negativos ou qualquer outro valor diferente do tipo esperado para o número de filhos,
// bem como a não permissão de qualquer outro valor diferente do tipo esperado para salário

decimal salario = 0;
int filhos = 0;
bool valorValido = false;
decimal maiorSalario = 0;
int quantidadeHabitantes = 0;
int quantidadeMenorQue150 = 0;  
decimal somaSalarios = 0;
int somaFilhos = 0;

while (salario >= 0)
{
    while (!valorValido)
    {
        Console.WriteLine("Qual é o seu salário? (Para parar, digite um salário negativo)");
        string entradaSalario = Console.ReadLine();

        if (decimal.TryParse(entradaSalario, out salario))
        {
            valorValido = true;
        }
        else
            Console.WriteLine("Salário inválido. Tente novamente.");
    }
    if (salario < 0)
    {
        break;
    }
    if (salario > maiorSalario)
    {
        maiorSalario = salario;
    }

    if (salario < 150)
    {
        quantidadeMenorQue150++;
    }

    valorValido = false;
    while (!valorValido)
    {
        Console.WriteLine("Quantos filhos você tem? ");
        string entradaFilhos = Console.ReadLine();

        if (int.TryParse(entradaFilhos, out filhos) && filhos >= 0)
        {
            valorValido = true;
        }
        else
            Console.WriteLine("Número de filhos inválido. Tente novamente.");
    }
    quantidadeHabitantes++;
    somaSalarios = somaSalarios + salario;
    somaFilhos = somaFilhos + filhos;
    valorValido = false;
}

decimal mediaSalarios = (decimal)somaSalarios / quantidadeHabitantes;
decimal mediaFilhos = (decimal)somaFilhos / quantidadeHabitantes;
decimal percentualMenorQue150 = (decimal)(quantidadeMenorQue150 * 100) / quantidadeHabitantes;

Console.WriteLine($"Média de salário da população: {mediaSalarios:F2}");
Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
Console.WriteLine($"Maior salário dos habitantes: {maiorSalario:F2}");
Console.WriteLine($"Percentual de pessoas com salário menor que R$ 150,00: {percentualMenorQue150:F2}%");