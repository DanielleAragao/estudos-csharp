// Questão 74 da lista: Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

// for (int contador1 = 1; contador1 <11; contador1++)
// {
//     for(int contador2 = 1; contador2 < 11; contador2++)
//     {
//         Console.WriteLine ($"{contador1} * {contador2} = {contador1*contador2}");
//     }
// }


// Questão 75 da lista: Escreva um algoritmo que imprima as seguintes seqüências de números: (1, 1 2 3 4 5 6 7 8 9 10)
//(2, 1 2 3 4 5 6 7 8 9 10) (3, 1 2 3 4 5 6 7 8 9 10) (4, 1 2 3 4 5 6 7 8 9 10) e assim sucessivamente, até
//que o primeiro número (antes da vírgula), também chegue a 10. 

for(int contador1 = 1; contador1 < 11; contador1++)
{
    Console.WriteLine(contador1);

    for(int contador2 = 1; contador2<11; contador2++)
    {
        Console.WriteLine(contador2);
    }
}