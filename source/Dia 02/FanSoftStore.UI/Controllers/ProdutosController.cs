using FanSoftStore.UI.Data;
using FanSoftStore.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FanSoftStore.UI.Controllers
{
    public class ProdutosController:Controller
    {

        private readonly FanSoftStoreDataContext _ctx;
        public ProdutosController(FanSoftStoreDataContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var model = _ctx.Produtos.Include(p=>p.Tipo).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEdit(Produto model)
        {
            _ctx.Produtos.Add(model);
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
