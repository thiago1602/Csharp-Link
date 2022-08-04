namespace Juncoes
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto {Nome = "Notebook", Preco = 12000, Categoria = "Informática"},
            new Produto {Nome = "Monitor", Preco = 80, Categoria = "Informática"},
            new Produto {Nome = "Cama", Preco = 1200, Categoria = "Móveis"},
            new Produto {Nome = "Armario", Preco = 400, Categoria = "Móveis"}
        };
        private static List<Promocao> promocoes = new List<Promocao>
        {
            new Promocao {Categoria = "Informática", Desconto = 10},
            new Promocao {Categoria = "Móveis", Desconto = 20}
            
        };

        static void Main(string[] args)
        {
            var result = from produto in produtos
            join promocao in promocoes on produto.Categoria equals promocao.Categoria
            select new {
                produto.Nome,
                produto.Categoria,
                PrecoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))

            };

            foreach(var p in result)
            {
                Console.WriteLine($"{p.Nome} - {p.Categoria} - {p.PrecoComDesconto}");
            }
        }
    }
}