using FanSoftStore.UI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FanSoftStore.UI.Controllers
{
    public class ProdutosController:Controller
    {

        private readonly FanSoftStoreDataContext _ctx = new FanSoftStoreDataContext();

        public IActionResult Index()
        {
            var model = _ctx.Produtos.ToList();
            return View(model);
        }

    }
}
