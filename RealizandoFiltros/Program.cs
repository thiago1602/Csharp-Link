namespace RealizandoFiltros
{
    class Program
    {
        private static List<Despesa> despesas = new List<Despesas>
        {
            new Despesa {Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021, 10, 01)},
            new Despesa {Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021, 10, 10)},
            new Despesa {Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021, 10, 15)},
            new Despesa {Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021, 10, 18)}
        };

        static void Main(string[] args)
        {
            var despesasVencidas = from d in despesas
                                   where d.Valor < 500 && d.Vencimento <= new DateTime(2021, 10, 30)
                                   orderby d.Vencimento descending, d.Valor ascending
                                   select d;
            foreach (var d in despesasVencidas)
            {
                Console.WriteLine(d);
            }
        }
    }
}