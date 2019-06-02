using Desenvolvimento_Web_2___Rodrigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desenvolvimento_Web_2___Rodrigo.Controllers
{
    public class CategoriaController : Controller
    {
        DevWeb2Entities ctx = new DevWeb2Entities();

        // GET: Categoria
        public ActionResult Index()
        {            
            return View(ctx.CATEGORIA.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CATEGORIA c)
        {
            if (ModelState.IsValid) {
                ctx.CATEGORIA.Add(c);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c);
        }
    }
}