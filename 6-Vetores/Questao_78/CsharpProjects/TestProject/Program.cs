// Questão 78: Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armaze os nomes lidos em
// um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa e depois
// escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes lidos anteriormente (guardados no
// vetor), ou NÃO ACHEI caso contrário.

//OBS: utilizei princípios de clean code criando variável para reutilizar em diferentes lugares. 

int contador = 0;
int tamanhoArray = 10;
string[] nomes = new string[tamanhoArray];

while (contador < tamanhoArray)
{
    Console.WriteLine($"Digite o nome da {contador + 1}ª pessoa:");
    string nome = Console.ReadLine();
    nomes[contador] = nome;
    contador++;
}
Console.WriteLine("Digite um nome qualquer:");
string nomeQualquer = Console.ReadLine();


bool achou = false;
foreach (string nome in nomes)
{
    if (nome.Equals(nomeQualquer))
    {
        achou = true;
        Console.WriteLine("ACHEI");
        break;
    }
}
if (achou == false)
        Console.WriteLine("NÃO ACHEI");