// Questão 59 da lista: Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.

// int contador;
// int total = 0;

// for (contador = 1; contador < 11; contador++)
// {
//     Console.WriteLine($"Digite o {contador}º valor");
//     int valor = int.Parse(Console.ReadLine());
//     if (valor < 0)
//     {
//         total = total + 1;
//     }
// }
// Console.WriteLine($"{total} números são negativos.");



// Questão 60 da lista: Ler 10 valores e escrever quantos desses valores lidos estão no intervalo [10,20] (inlcuindo os
// valores 10 e 20 no intervalo) e quantos deles estão fora deste intervalo.

// int contador;
// int totalDentro = 0;
// int totalFora = 0;

// for (contador = 1; contador < 11; contador++)
// {
//     Console.WriteLine($"Escreva o {contador}° valor:");
//     int valor = int.Parse(Console.ReadLine());

//     if (valor >= 10 && valor <= 20)
//     {
//         totalDentro = totalDentro + 1;
//     }
//     else
//         totalFora ++;
// }
// Console.WriteLine($"O total de números dentro do intervalo [10,20] é de: {totalDentro}");
// Console.WriteLine($"O total de números fora do intervalo [10,20] é de: {totalFora}");




// Questão 61 da lista: Ler 10 valores, calcular e escrever a média aritmética desses valores lidos. 

int contador = 1;
decimal soma = 0;

while (contador <11)
{
    Console.WriteLine($"Digite o {contador}° valor:");
    decimal valor = decimal.Parse(Console.ReadLine());
    soma = soma + valor;  
    contador++; 
}
decimal media = soma/10m;
Console.WriteLine("A média aritmética dos valores lidos é de: " + media);
