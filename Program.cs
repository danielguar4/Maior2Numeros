int First, Second;

Console.Write("Digite o primeiro número...: ");
First = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o Segundo Numero....: ");
Second = Convert.ToInt32(Console.ReadLine());

if (First > Second)
{
    Console.WriteLine($"O maior número é {First}");
}
else
{
    Console.WriteLine($"O maior número é {Second}");
}