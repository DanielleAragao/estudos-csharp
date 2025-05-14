// Questão 50 da lista: Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem
// crescente.

//OBS: resolvi a questão utilizando quatro soluções diferentes.

//resolução utilizando o while:

int valor = 1;
while (valor <= 10)
{
    Console.WriteLine(valor);
    valor++;
}

//resolução utilizando o do-while:

// int valor = 1;
// do
// {
//     Console.WriteLine(valor);
//     valor++;
// }
// while (valor <= 10);


//resoluções utilizando o for:
//resolução 1:

// for (int valor = 1; valor <= 10; valor ++)
// {
//     Console.WriteLine(valor);
// }  

//resolução 2:

// int valor = 1;
// for (int contador = 0; contador < 10; contador++)
// {
//     Console.WriteLine(valor);
//     valor++;
// }






// Questão 51 da lista: Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10 (inclusive) em ordem
// decrescente.

//OBS: resolvi a questão utilizando quatro soluções diferentes.

//resoluções utilizando o for:
//resolução 1:

// for(int valor = 10; valor>=1; valor--) 
// {
//     Console.WriteLine(valor);
// }

//resolução 2:

// int valor = 10;
// for (int contador = 0; contador < 10; contador++)
// {
//     Console.WriteLine(valor);
//     valor--;
// }


//resolução utilizando o while:

// int valor = 10;
// while (valor >= 1) 
// {
//     Console.WriteLine(valor);
//     valor--;
// }


//resolução utilizando o do-while:

// int valor = 10;
// do
// {
//     Console.WriteLine(valor);
//     valor --;
// }
// while (valor >= 1);  






// Questão 52 da lista: Escreva um algoritmo para imprimir os 10 primeiros números inteiros maiores que 100. 

//OBS: resolvi a questão utilizando seis soluções diferentes.

//resoluções utilizando o for:
//resolução 1:
// int valor = 101;
// for (int contador = 0; contador < 10; contador ++)
// {
//     Console.WriteLine (valor);
//     valor ++;
// }

//resolução 2:
// for (int valor = 101; valor <=110; valor ++)
// {
//     Console.WriteLine (valor);
// }

//resoluções utilizando o while:
//resolução 1:
// int valor= 101;
// while (valor <= 110)
// {
//     Console.WriteLine(valor);
//     valor ++;       
// }

//resolução 2:

// int valor = 101;
// int contador = 1;
// while (contador <= 10)
// {
//     Console.WriteLine(valor);
//     valor ++;
//     contador ++;
// }

//resoluções utilizando o do-while:
//resolução 1:
// int valor= 101;
// do
// {
//     Console.WriteLine(valor);
//     valor++;
// }
// while (valor <= 110);

//resolução 2:

// int valor = 101;
// int contador = 1;
// do
// {
//     Console.WriteLine(valor);
//     valor ++;
//     contador ++;
// }
// while (contador <=10);