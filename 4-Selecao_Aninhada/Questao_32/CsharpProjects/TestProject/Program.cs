// Questão 32 da lista: Ler o nome de 2 times e o número de gols marcados na partida (para cada time). Escrever o nome
// do vencedor. Caso não haja vencedor deverá ser impressa a palavra EMPATE. 

//OBS: incrementei o código com a exibição do nome do time digitado anteriormente pelo usuário no momento de solicitar quantos gols foram feitos. Além disso, 
//incrementei a resposta para informar também o número de gols marcados pelo vencedor.

Console.WriteLine("Digite o nome do primeiro time: ");
string time1 = Console.ReadLine();

Console.WriteLine($"Qual o número de gols marcados por {time1}?");
int gols1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do segundo time: ");
string time2 = Console.ReadLine();

Console.WriteLine($"Qual o número de gols marcados por {time2}?");
int gols2 = int.Parse(Console.ReadLine());

if (gols1 > gols2)
Console.WriteLine($"O vencedor é: {time1} com {gols1} gols");
else if (gols1 < gols2)
Console.WriteLine($"O vencedor é: {time2} com {gols2} gols");
else
Console.WriteLine("EMPATE");

