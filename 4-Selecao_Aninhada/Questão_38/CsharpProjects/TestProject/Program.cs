// Questão 38 da lista: Faça um algoritmo para ler um número que é um código de usuário. Caso este código seja
// diferente de um código armazenado internamente no algoritmo (igual a 1234) deve ser apresentada a
// mensagem ‘Usuário inválido!’. Caso o Código seja correto, deve ser lido outro valor que é a senha. Se
// esta senha estiver incorreta (a certa é 9999) deve ser mostrada a mensagem ‘senha incorreta’. Caso a
// senha esteja correta, deve ser mostrada a mensagem ‘Acesso permitido’.

Console.WriteLine("Digite o código de usuário: ");
int codigoUsuario = int.Parse(Console.ReadLine());

if (codigoUsuario != 1234)
    Console.WriteLine("Usuário inválido!");

else
{
    Console.WriteLine("Digite a senha: ");
    int senhaUsuario = int.Parse(Console.ReadLine());

    if (senhaUsuario == 9999)
        Console.WriteLine("Acesso permitido");

    else
        Console.WriteLine("Senha incorreta");
}



