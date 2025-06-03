// Questão 84: Faça um algoritmo para ler um valor N qualquer (que será o tamanho dos vetores). Após, ler dois
// vetores A e B (de tamanho N cada um) e depois armazenar em um terceiro vetor Soma a soma dos
// elementos do vetor A com os do vetor B (respeitando as mesmas posições) e escrever o vetor Soma. 

Console.WriteLine("Digite o tamanho dos vetores:");
int N = int.Parse(Console.ReadLine());

decimal[] A = new decimal[N];
decimal[] B = new decimal[N];
decimal[] Soma = new decimal[N];
int contador = 0;

while (contador < N)
{
    Console.WriteLine($"Digite o elemento {contador + 1} do vetor A:");
    A[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}

contador = 0;
while (contador < N)
{
    Console.WriteLine($"Digite o elemento {contador + 1} do vetor B:");
    B[contador] = decimal.Parse(Console.ReadLine());
    contador++;
}

for (contador = 0; contador < N; contador++)
{
    Soma[contador] = A[contador] + B[contador];
    Console.WriteLine(Soma[contador]);
}