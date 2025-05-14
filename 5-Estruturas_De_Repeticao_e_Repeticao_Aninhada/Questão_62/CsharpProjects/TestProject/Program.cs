// Questão 62 da lista: Ler o número de alunos existentes em uma turma e, após isto, ler as notas destes alunos, calcular e
// escrever a média aritmética dessas notas lidas. 

Console.WriteLine("Quantos alunos há na turma?");
int quantidadeDeAlunos = int.Parse(Console.ReadLine());

int contador = 1;
decimal soma = 0;
do
{
    Console.WriteLine($"Digite a nota do {contador}° aluno:");
    decimal nota = decimal.Parse(Console.ReadLine());
    soma = soma + nota;
    contador ++;
}
while (contador < quantidadeDeAlunos + 1);

decimal media = (decimal)(soma / quantidadeDeAlunos);
Console.WriteLine("A média aritmética dessas notas é: " + media);