using System.Net.Http.Headers;

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double total = sp + rj + mg + es + outros;

Console.WriteLine($"Porcentagens por Estado: ");
CalcularPorcentagem("SP", sp, total);
CalcularPorcentagem("RJ", rj, total);
CalcularPorcentagem("MG", mg, total);
CalcularPorcentagem("ES", es, total);
CalcularPorcentagem("Outros", outros, total);
static void CalcularPorcentagem(string estado, double valor, double total)
{
    double porcentagem = (valor / total) * 100;
    Console.WriteLine($"{estado}: {porcentagem:F2}%");
}
