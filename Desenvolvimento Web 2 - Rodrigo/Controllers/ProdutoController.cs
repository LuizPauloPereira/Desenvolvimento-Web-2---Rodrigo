using Desenvolvimento_Web_2___Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desenvolvimento_Web_2___Rodrigo.Controllers
{
    public class ProdutoController : Controller
    {
        DevWeb2Entities ctx = new DevWeb2Entities();


        // GET: Produto
        public ActionResult Index()
        {
            return View(ctx.PRODUTO.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(ctx.CATEGORIA.ToList(), "Id", "Descricao");
            return View();
        }
        [HttpPost]
        public ActionResult Create(PRODUTO p)
        {
            if (ModelState.IsValid)
            {
                ctx.PRODUTO.Add(p);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(p);
        }
    }
}