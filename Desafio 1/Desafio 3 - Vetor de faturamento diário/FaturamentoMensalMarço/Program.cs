using Newtonsoft.Json;


class Faturamento
{
    public double Valor { get;  set; }

    class Faturamentos
    {
        public string Dia { get; set; }
        public double Valor { get; set; }
    }
    static void Main()
    {
        string caminhoDoArquivo = @"G:\desafio\Desafio_TargetSistemas\Desafio 1\Desafio 3 - Vetor de faturamento diário\marco_fatur.JSON";
        string json = File.ReadAllText(caminhoDoArquivo);

        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        double menorFaturamento = faturamentos.Min(n => n.Valor);
        double maiorFaturamento = faturamentos.Max(n => n.Valor);
        double mediaFaturamento = faturamentos.Average(n => n.Valor);
        double mediaArrendada = Math.Round(mediaFaturamento, 2);
        int diasAcimaDaMedia = faturamentos.Count(n => n.Valor > mediaFaturamento);



        Console.WriteLine($"O valor mínimo do nosso faturamento foi de: {menorFaturamento:C}.");
        Console.WriteLine($"O maior valor do nosso faturamento foi de: {maiorFaturamento:C}.");
        Console.WriteLine($"Nossos dias com o maior faturamento diário foram {diasAcimaDaMedia} dias, com a média de: {mediaArrendada:C}!");
        Console.ReadKey();

    }
}