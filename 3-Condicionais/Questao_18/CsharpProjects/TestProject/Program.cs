// Questão 18: Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela
// poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu). 

//OBS: incrementei a resposta para que seja exibida a idade da pessoa além da mensagem da possibilidade de voto.

Console.WriteLine ("Qual o ano atual?");
int anoAtual = int.Parse(Console.ReadLine ());

Console.WriteLine ("Qual seu ano de nascimento?");
int anoNascimento = int.Parse(Console.ReadLine ());

int idade = anoAtual - anoNascimento;

if (idade >= 18)
    Console.WriteLine ($"Você possui {idade} anos e poderá votar este ano");
else
    Console.WriteLine ($"Você possui {idade} anos e não poderá votar este ano");