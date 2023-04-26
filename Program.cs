// Determine se um ano fornecido pelo usuário é ou não bissexto.
Console.WriteLine("--- Anos Bissexto ---\n");

Console.Write("Digite o ano...:");
int ano = int.Parse(Console.ReadLine()!);

if ((ano % 400 == 0) || ((ano % 4 == 0) && (ano % 100 != 0))) {
    Console.WriteLine($"\nO ano {ano} é bissexto.", ano);
}
else {
    Console.WriteLine($"\nO ano {ano} não é bissexto.", ano);
}