// Questão 26 da lista: Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e
// quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade
// média = quantidade máxima + quantidade mínima)/2). Se a quantidade em estoque for maior ou igual
// a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar
// compra'.

Console.WriteLine("Qual a quantidade atual em estoque? ");
int quantAtual = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a quantidade máxima em estoque? ");
int quantMaxima = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a quantidade mínima em estoque? ");
int quantMinima = int.Parse(Console.ReadLine());

decimal quantMedia = (quantMaxima + quantMinima) / 2;

if (quantAtual > quantMedia)
    Console.WriteLine("Não efetuar compra");
else
    Console.WriteLine("Efetuar compra");
