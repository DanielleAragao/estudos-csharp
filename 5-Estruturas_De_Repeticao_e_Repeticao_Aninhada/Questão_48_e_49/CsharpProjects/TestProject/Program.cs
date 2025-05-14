// Questão 48 da lista: Escreva um algoritmo para ler as notas da 1a. e 2a. avaliações de um aluno, calcule e imprima a
// média (simples) desse aluno. Só devem ser aceitos valores válidos durante a leitura (0 a 10) para cada
// nota.

// Console.WriteLine("Qual a nota da 1ª avaliação? ");
//     decimal nota1 = decimal.Parse(Console.ReadLine());

//     while (nota1 < 0 || nota1 > 10)
//     {
//         Console.WriteLine("Nota inválida. Digite uma outra nota entre 0 e 10: ");
//         nota1 = decimal.Parse(Console.ReadLine());
//     }

//     Console.WriteLine("Qual a nota da 2ª avaliação? ");
//     decimal nota2 = decimal.Parse(Console.ReadLine());

//     while (nota2 < 0 || nota2 > 10)
//     {
//         Console.WriteLine("Nota inválida. Digite uma outra nota entre 0 e 10: ");
//         nota2 = decimal.Parse(Console.ReadLine());
//     }
//     decimal media = (nota1 + nota2) / 2;
//     Console.WriteLine("Sua média é de: " + media);



// OBS: a questão seguinte refere-se à questão acima. Deixei a resposta comentada para não ocorrer erro.


// Questão 49 da lista: Acrescente uma mensagem 'NOVO CÁLCULO (S/N)?' ao final do exercício [48]. Se for
// respondido 'S' deve retornar e executar um novo cálculo, caso contrário deverá encerrar o algoritmo.

//OBS: incrementei a resposta com uma validação para caso seja digitado algo diferente de "S" ou "N" também.

string resultado;
do
{
    Console.WriteLine("Qual a nota da 1ª avaliação? ");
    decimal nota1 = decimal.Parse(Console.ReadLine());

    while (nota1 < 0 || nota1 > 10)
    {
        Console.WriteLine("Nota inválida. Digite uma outra nota entre 0 e 10: ");
        nota1 = decimal.Parse(Console.ReadLine());
    }

    Console.WriteLine("Qual a nota da 2ª avaliação? ");
    decimal nota2 = decimal.Parse(Console.ReadLine());

    while (nota2 < 0 || nota2 > 10)
    {
        Console.WriteLine("Nota inválida. Digite uma outra nota entre 0 e 10: ");
        nota2 = decimal.Parse(Console.ReadLine());
    }
    decimal media = (nota1 + nota2) / 2;
    Console.WriteLine("Sua média é de: " + media);
    Console.WriteLine("Novo cálculo (S/N)? ");
    resultado = Console.ReadLine().ToUpper();
    while (resultado != "N" && resultado != "S")
    {
        Console.WriteLine("Digite apenas \"S\" ou \"N\": ");
        resultado = Console.ReadLine().ToUpper();
    }
}
while (resultado == "S");
