Console.WriteLine("Insira um texto: \b");
string texto = Convert.ToString(Console.ReadLine());
string textoInvertido = "";

for (int i = texto.Length - 1; i >= 0; i--)
{
    textoInvertido += texto[i];
    // A variável textoInvertido será atribuída com os caractéres de texto inversamente ordenados.
}
Console.WriteLine($"Seu texto era: {texto}");
Console.WriteLine($"Agora ele é: {textoInvertido}");
Console.WriteLine("Invertido :D");
Console.ReadKey();