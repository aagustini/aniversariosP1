using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AniversariosBLL;

namespace AniversariosP1.Controllers
{
    public class AniversariosController : Controller
    {
        private AniversariosFachada fachada = new AniversariosFachada();

        // GET: Aniversarios
        public ActionResult Index()
        {
            return View(fachada.buscarAniversarios());
        }

      
        // GET: Aniversarios/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Aniversarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AniversarioId,Nome,DataAniversario")] Aniversario aniversario)
        {
            if (ModelState.IsValid)
            {
                fachada.cadastarAniversario(aniversario.Nome, aniversario.DataAniversario);
                return RedirectToAction("Index");
            }

            return View(aniversario);
        }

      
     
    }
}
