// Questão 36 da lista: Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres (considere que as idades
// dos homens serão sempre diferentes entre si, bem como as das mulheres). Calcule e escreva a soma
// das idades do homem mais velho com a mulher mais nova, e o produto das idades do homem mais
// novo com a mulher mais velha. 

Console.WriteLine("Digite a idade do primeiro homem:");
int idadeHomem1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade do segundo homem: ");
int idadeHomem2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade da primeira mulher:");
int idadeMulher1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade da segunda mulher: ");
int idadeMulher2 = int.Parse(Console.ReadLine());

int maiorIdadeHomem;
int menorIdadeHomem;
int maiorIdadeMulher;
int menorIdadeMulher;

if (idadeHomem1 > idadeHomem2)
{
    maiorIdadeHomem = idadeHomem1;
    menorIdadeHomem = idadeHomem2;
}
else
{
    maiorIdadeHomem = idadeHomem2;
    menorIdadeHomem = idadeHomem1;
}

if (idadeMulher1 > idadeMulher2)
{
    maiorIdadeMulher = idadeMulher1;
    menorIdadeMulher = idadeMulher2;
}
else
{
    maiorIdadeMulher = idadeMulher2;
    menorIdadeMulher = idadeMulher1;
}

Console.WriteLine($"A soma das idades do homem mais velho com a mulher mais nova é de: {maiorIdadeHomem + menorIdadeMulher}");
Console.WriteLine($"O produto das idades do homem mais novo com a mulher mais velha é de: {menorIdadeHomem * maiorIdadeMulher}");
