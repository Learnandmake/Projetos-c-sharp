using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace site.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        public ActionResult Home()
        {
            return View();
        }

       [HttpPost]
        public ActionResult inserir(model.venda model)
        {
       business.vendasbusiness bvenda = new business.vendasbusiness();
            bvenda.inserir(model);
            return View();
        }
        public ActionResult inserir()
        {
            return View();
        }
        public ActionResult lista()
        {
            business.vendasbusiness bvendas = new business.vendasbusiness();
           List<model.venda> lista= bvendas.listar();
           
            return View(lista);
        }
    }
}