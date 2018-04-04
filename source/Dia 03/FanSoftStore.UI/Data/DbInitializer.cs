using FanSoftStore.UI.Models;
using System.Collections.Generic;
using System.Linq;

namespace FanSoftStore.UI.Data
{
    public class DbInitializer
    {

        public static void Init(FanSoftStoreDataContext ctx)
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Produtos.Any())
            {

                var alimentacao = new TipoProduto() { Nome="Alimentação"};
                var higiene = new TipoProduto() { Nome="Higiene"};
                var vestuario = new TipoProduto() { Nome="Vestuario"};

                var produtos = new List<Produto>() {
                        new Produto(){ Nome = "Picanha", Tipo = alimentacao, Valor= 80.99M},
                        new Produto(){ Nome = "Fralda", Tipo = higiene, Valor= 50.99M},
                        new Produto(){ Nome = "Pasta de Dente", Tipo = higiene, Valor= 10.50M},
                        new Produto(){ Nome = "Iogurte", Tipo = alimentacao, Valor= 9.99M},
                        new Produto(){ Nome = "Camisa Polo", Tipo = vestuario, Valor= 100.99M}
                };


                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();

            }



        }

    }
}
