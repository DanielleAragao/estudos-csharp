// Questão 22: A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais
// de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%.
// Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva
// o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
// (considere que o mês possua 4 semanas exatas). 

Console.WriteLine("Quantas horas você trabalhou no mês?");
decimal horasMensais = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor da hora regular?");
decimal valorHora = decimal.Parse(Console.ReadLine());

decimal horasExtras = horasMensais - 160;
decimal salario;

if (horasExtras > 0)
{
    salario = (horasExtras * (0.5m * valorHora + valorHora) + (160*valorHora));
    Console.WriteLine($"Seu salário total é de R${salario}");
}
else
{
    salario = horasMensais*valorHora;
    Console.WriteLine($"Seu salário total é de R${salario}");
}

