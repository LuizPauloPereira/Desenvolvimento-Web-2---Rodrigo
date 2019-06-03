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
            if (ModelState.IsValid)
            {
                ctx.CATEGORIA.Add(c);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c);
        }

        public ActionResult Edit(int id)
        {
            return View(ctx.CATEGORIA.Find(id));
        }
        [HttpPost]
        public ActionResult Edit (CATEGORIA c)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }

        public ActionResult Delete(int id)
        {
            return View(ctx.CATEGORIA.Find(id));
        }
        [HttpPost]
        public ActionResult Delete(CATEGORIA c)
        {
            ctx.CATEGORIA.Remove(ctx.CATEGORIA.Find(c.Id));
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(ctx.CATEGORIA.Find(id));
        }
    }
}