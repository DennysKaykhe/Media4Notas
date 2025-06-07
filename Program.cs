Console.Clear();

Console.WriteLine("-- Média -- \nDigite as suas notas abaixo.");
Console.Write("Nota 1: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

if (nota1 > 10 || nota1 < 0)
{
    Console.Clear();
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Console.ReadKey();
    Console.Clear();
    return;
}

Console.Write("Nota 2: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

if (nota2 > 10 || nota2 < 0)
{
    Console.Clear();
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Console.ReadKey();
    Console.Clear();
    return;
}

Console.Write("Nota 3: ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

if (nota3 > 10 || nota3 < 0)
{
    Console.Clear();
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Console.ReadKey();
    Console.Clear();
    return;
}

Console.Write("Nota 4: ");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());

if (nota4 > 10 || nota4 < 0)
{
    Console.Clear();
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Console.ReadKey();
    Console.Clear();
    return;
}

decimal NotaFinal;
NotaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

string resultado = ".";

if (NotaFinal < 5)

{
    resultado = "Reprovado";
}
else if (NotaFinal > 5 || NotaFinal < 6)
{
    resultado = "Em recuperaão";
}
else
{
    resultado = "Aprovado";
}

    Console.WriteLine($"\nVocê ficou com média {NotaFinal}. Resultado: {resultado}");
Console.ReadKey();
Console.Clear();
return;
