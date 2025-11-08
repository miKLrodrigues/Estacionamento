Console.WriteLine("+----------------+");
Console.WriteLine("| Estacionamento |");
Console.WriteLine("+----------------+");

Console.Write("Tamanho do veículo (P/G): ");
char tamanho = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

Console.Write("Tempo de permanência (min): ");
decimal minutos = decimal.Parse(Console.ReadLine() ?? "0");

Console.Write("Serviço de valet (S/N): ");
char valet = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

Console.Write("Serviço de lavagem (S/N): ");
char lavagem = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();


if (minutos > 720)
{
    Console.WriteLine("\nTempo de permanência não pode exceder 12 horas.");
    return;
}


decimal horas = Math.Round(minutos/60, MidpointRounding.AwayFromZero);

decimal estacionamento = 0;
decimal valorValet = 0;
decimal valorLavagem = 0;


if (tamanho == 'g')
{
    if (horas >= 5)
        estacionamento = 80;
    else if (horas <= 1)
        estacionamento = 20;
    else
        estacionamento = 20 + (horas - 1) * 20;
}
else if (tamanho == 'p')
{
    if (horas >= 5)
        estacionamento = 50;
    else if (horas <= 1)
        estacionamento = 20;
    else
        estacionamento = 20 + (horas - 1) * 10;
}
else
{
    Console.WriteLine("\nTamanho inválido! Use 'P' para pequeno ou 'G' para grande.");
    return;
}


if (valet == 's')
    valorValet = estacionamento * 0.20m;


if (lavagem == 's')
    valorLavagem = (tamanho == 'g') ? 100 : 50;


decimal total = estacionamento + valorValet + valorLavagem;

Console.WriteLine("\n┌────────────────┐");
Console.WriteLine("│ Estacionamento │");
Console.WriteLine("└────────────────┘");

Console.WriteLine($"Estacionamento...: R$ {estacionamento:F2}");
Console.WriteLine($"Valet............: R$ {valorValet:F2}");
Console.WriteLine($"Lavagem..........: R$ {valorLavagem:F2}");

Console.WriteLine("----------------------------");
Console.WriteLine($"Total............: R$ {total:F2}");


