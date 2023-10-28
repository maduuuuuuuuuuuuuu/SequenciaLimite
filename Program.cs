int numeroum, numerodois;
int auxiliar;

do
{
    Console.Write("Digite um  número: ");
    Int32.TryParse(Console.ReadLine(), out numeroum);

    Console.Write("Digite outro número: ");
    Int32.TryParse(Console.ReadLine(), out numerodois);
    Console.WriteLine();
    


    if (numeroum > numerodois)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Número inválido");
        Console.ResetColor();
        Console.WriteLine();
    }
    else
    {
    
    }
}
while (numeroum > numerodois);

auxiliar = numeroum;

while(auxiliar < numerodois)
{
    Console.Write($"{auxiliar} ");
    auxiliar++;
}
    
    Console.WriteLine();
    Console.WriteLine($"Esta foi a sequência numérica de {numeroum} a {numerodois}");
    Console.WriteLine();


