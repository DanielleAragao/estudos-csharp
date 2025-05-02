// Questão 21 da lista: Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os
// minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é
// de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte. 

Console.WriteLine("Qual a hora de início do jogo?");
int horaInicio = int.Parse(Console.ReadLine());

Console.WriteLine("Qual a hora do fim do jogo?");
int horaFinal = int.Parse(Console.ReadLine());  
int tempoTotal;

if (horaInicio < horaFinal)
{
    tempoTotal = horaFinal - horaInicio;
    Console.WriteLine($"O tempo total de jogo foi de {tempoTotal} horas");
}
else
{
    tempoTotal = (24 - horaInicio) + horaFinal;  
    Console.WriteLine($"O tempo total de jogo foi de {tempoTotal} horas");
}  

