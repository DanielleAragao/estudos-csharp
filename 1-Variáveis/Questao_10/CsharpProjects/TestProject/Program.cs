// Questão 10 da lista: O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do
// distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do distribuidor
// seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de fábrica de um carro,
// calcular e escrever o custo final ao consumidor. 

Console.WriteLine("Qual o custo de fábrica do carro?");
decimal custoFabrica = decimal.Parse (Console.ReadLine());

decimal porcDistribuidor = 0.28m;
decimal porcImpostos = 0.45m;
decimal custoFinal= custoFabrica + (porcDistribuidor*custoFabrica) + (porcImpostos*custoFabrica);
Console.WriteLine($"O custo final ao consumidor será de: {custoFinal}");
// ou:
// decimal custoFinal= custoFabrica + ((28m*custoFabrica)/100m) + ((45m*custoFabrica)/100m);
// Console.WriteLine($"O custo final ao consumidor será de: {custoFinal:C}");