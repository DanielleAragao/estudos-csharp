// Questão 8 da lista: Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
// brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total
// de eleitores. 

Console.WriteLine("Qual o número total de eleitores?");
int total = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o número de votos brancos?");
int brancos = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o número de votos nulos?");
int nulos = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o número de votos válidos?");
int validos = int.Parse(Console.ReadLine());

decimal percBrancos = (decimal)(brancos * 100)/total;
decimal percNulos = (decimal)(nulos * 100)/total;
decimal percValidos = (decimal)(validos * 100)/total;
Console.WriteLine("Percentual de votos brancos: " + percBrancos + "%");
Console.WriteLine("Percentual de votos nulos: " + percNulos + "%");
Console.WriteLine("Percentual de votos válidos: " + percValidos + "%");
