// Questão 79 da lista: Escreva um algoritmo que permita a leitura das notas de uma turma de 20 alunos. Calcular a média
// da turma e contar quantos alunos obtiveram nota acima desta média calculada. Escrever a média da
// turma e o resultado da contagem.

int contador = 0;   
decimal[] notas = new decimal[20]; 
decimal somaNotas = 0;
int acimaDaMedia = 0;   

while (contador < 20)
{
    Console.WriteLine($"Digite a nota do {contador + 1}º aluno:");
    notas[contador] = decimal.Parse(Console.ReadLine());
    somaNotas =  somaNotas + notas[contador];
    contador++;
}   
decimal media = somaNotas/20;

foreach (decimal nota in notas)
{
    if (nota > media)
    {
        acimaDaMedia++;
    }
}

Console.WriteLine($"A média da turma é: {media}");  
Console.WriteLine($"Número de alunos acima da média: {acimaDaMedia}");