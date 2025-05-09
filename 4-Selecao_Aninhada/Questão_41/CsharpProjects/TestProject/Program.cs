// Questão 42 da lista: Uma empresa quer verificar se um empregado está qualificado para a aposentadoria ou não. Para
// estar em condições, um dos seguintes requisitos deve ser satisfeito:
//  - Ter no mínimo 65 anos de idade.
//  - Ter trabalhado no mínimo 30 anos.
//  - Ter no mínimo 60 anos e ter trabalhado no mínimo 25 anos.
// Com base nas informações acima, faça um algoritmo que leia: o número do empregado (código), o ano
// de seu nascimento e o ano de seu ingresso na empresa. O programa deverá escrever a idade e o tempo
// de trabalho do empregado e a mensagem 'Requerer aposentadoria' ou 'Não requerer'.

//OBS: algo que achei interessante quando estava resolvendo a questão é o que está na linha 23, estava dando erro 
//porque eu estava colocando o tipo DateTime para a variável "anoAtual", quando, na verdade, deveria ser o tipo int
//porque o "Now.Year" extrai apenas o ano e retorna um inteiro.

Console.WriteLine("Qual o seu número (código)? ");
int codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu ano de nascimento? ");
int anoDeNascimento = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o ano em que você ingressou na empresa? ");
int anoDeIngresso = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoDeNascimento;
int tempoDeTrabalho = anoAtual - anoDeIngresso;
Console.WriteLine($"Sua idade é de {idade} anos, seu tempo de trabalho é de {tempoDeTrabalho} anos."); 

if ((idade >= 65) || (tempoDeTrabalho >= 30) || ((idade >= 60 && tempoDeTrabalho >= 25)))
    Console.WriteLine("Você pode requerer a aposentadoria.");

else
    Console.WriteLine("Você não pode requerer a aposentadoria.");