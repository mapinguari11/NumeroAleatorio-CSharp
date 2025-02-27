Random numeroAleatorio = new Random();
int numeroSecreto = numeroAleatorio.Next(1, 101);

do
{
    Console.WriteLine("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número secreto.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número secreto é maior.");
    }
    else
    {
        Console.WriteLine("O número secreto é menor.");
    }
} while (true);

Console.WriteLine("Você acertou o número secreto! Parabéns!");
Console.WriteLine("\nPressione qualquer tecla para sair.");
Console.ReadKey();