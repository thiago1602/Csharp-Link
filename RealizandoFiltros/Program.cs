namespace RealizandoFiltros
{
    class Program
    {
        private static List<Despesas> despesas = new List<Despesas>
        {
            new Despesas {Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021, 10, 01)},
            new Despesas {Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021, 10, 10)},
            new Despesas {Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021, 10, 15)},
            new Despesas {Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021, 10, 18)}
        };

        static void Main(string[] args)
        {
            var despesasVencidas = from d in despesas
                                   where d.Valor < 500 && d.Vencimento <= new DateTime(2021, 10, 30)
                                   select d;
            foreach (var d in despesasVencidas)
            {
                Console.WriteLine(d);
            }
        }
    }
}