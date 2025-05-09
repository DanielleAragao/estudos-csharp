// Questão 35 da lista: Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool: até 20 litros, desconto de 3% por litro | acima de 20 litros, desconto de 5% por litro
// Gasolina: até 20 litros, desconto de 4% por litro | acima de 20 litros, desconto de 6% por litro
// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da
// seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se
// que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90. 

//OBS: respondi de duas formas: uma usando o if-else e outra usando o switch-case. 
//Além disso, incrementei todas as respostas com a possibilidade de o usuário digitar um tipo de combustível inválido.


//1ª forma: com if-else
Console.WriteLine("Qual o combustível escolhido (A-álcool, G-gasolina)? ");
string nomeCombustivel = Console.ReadLine().ToUpper();

Console.WriteLine("Quantos litros foram vendidos? ");
int litrosCombustivel = int.Parse(Console.ReadLine());

decimal valorTotal;

if (nomeCombustivel == "G")
{
    if (litrosCombustivel < 20)
    {
        valorTotal = (litrosCombustivel * 3.3m) - (litrosCombustivel * (3.3m * (4m / 100m)));
        Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
    }
    else
    {
        valorTotal = (litrosCombustivel * 3.3m) - (litrosCombustivel * (3.3m * 0.06m));
        Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
    }
}

else if (nomeCombustivel == "A")
{
    if (litrosCombustivel < 20)
    {
        valorTotal = (litrosCombustivel * 2.9m) - (litrosCombustivel * (2.9m * (3m / 100m))); ;
        Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
    }
    else
    {
        valorTotal = (litrosCombustivel * 2.9m) - (litrosCombustivel * (2.9m * (5m / 100m)));
        Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
    }
}

else
    Console.WriteLine("Nome de combustível inválido.");



// 2ª forma: switch-case
Console.WriteLine("Qual o combustível escolhido (A-álcool, G-gasolina)? ");
string nomeCombustivel = Console.ReadLine().ToUpper();

Console.WriteLine("Quantos litros foram vendidos? ");
int litrosCombustivel = int.Parse(Console.ReadLine());

decimal valorTotal;

switch (nomeCombustivel)
{
    case "G":
        if (litrosCombustivel < 20)
        {
            valorTotal = (litrosCombustivel * 3.3m) - (litrosCombustivel * (3.3m * (4m / 100m)));
            Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
        }
        else
        {
            valorTotal = (litrosCombustivel * 3.3m) - (litrosCombustivel * (3.3m * 0.06m));
            Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
        }
        break;

    case "A":
        if (litrosCombustivel < 20)
        {
            valorTotal = (litrosCombustivel * 2.9m) - (litrosCombustivel * (2.9m * (3m / 100m))); ;
            Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
        }
        else
        {
            valorTotal = (litrosCombustivel * 2.9m) - (litrosCombustivel * (2.9m * (5m / 100m)));
            Console.WriteLine($"O valor total pago foi de {valorTotal:F2}");
        }
        break;

    default:
        Console.WriteLine("Tipo de combustível inválido.");
        return;
}




