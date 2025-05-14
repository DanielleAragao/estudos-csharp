// Questão 53 da lista: Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N (inclusive). Considere
// que o N será sempre maior que ZERO. 

// int valorN;
// do
// {
// Console.WriteLine("Digite o valor de \"N\": ");
// valorN = int.Parse(Console.ReadLine());
// }
// while (valorN == 0);

// for (int contador = 1;  contador <= valorN; contador ++)
// {
//     Console.WriteLine(contador);
// }



// Questão 54 da lista: Modifique o exercício anterior para aceitar somente valores maiores que 0 para N. Caso o valor
// informado (para N) não seja maior que 0, deverá ser lido um novo valor para N. 

Console.WriteLine("Digite o valor de N: ");
int valorN = int.Parse(Console.ReadLine());

while(valorN <= 0)
{
Console.WriteLine("O valor de N deve ser maior que zero. Digite um novo valor para N: ");
valorN = int.Parse(Console.ReadLine());
}

int cont;
for(cont = 1; cont <= valorN; cont++)
{
    Console.WriteLine(cont);
}