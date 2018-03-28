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
                var produtos = new List<Produto>() {
                        new Produto(){ Nome = "Picanha", Tipo = "Alimentação", Valor= 80.99M},
                        new Produto(){ Nome = "Fralda", Tipo = "Higiene", Valor= 50.99M},
                        new Produto(){ Nome = "Pasta de Dente", Tipo = "Higiene", Valor= 10.50M},
                        new Produto(){ Nome = "Iogurte", Tipo = "Alimentação", Valor= 9.99M},
                        new Produto(){ Nome = "Camisa Polo", Tipo = "Vestuário", Valor= 100.99M}
                };


                ctx.Produtos.AddRange(produtos);
                ctx.SaveChanges();

            }



        }

    }
}
