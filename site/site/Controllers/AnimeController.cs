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
        public ActionResult admcadastro(model.administrador model)
        {
       business.administradorbusiness badm = new business.administradorbusiness();
            badm.inserir(model);
            return View();
        }
        public ActionResult admcadastro()
        {
            return View();
        }



        [HttpPost]
        public ActionResult clientecadastro (model.cliente model)
        {
            business.clientebusiness bcliente = new business.clientebusiness();
            bcliente.inserir(model);
            return View();
        }
        public ActionResult clientecadastro()
        {
            return View();
        }



        [HttpPost]
        public ActionResult logincadastro(model.login model)
        {
            business.loginbusiness blogin = new business.loginbusiness();
            blogin.inserir(model);
            return View();
        }
        public ActionResult logincadastro()
        {
            return View();
        }



        [HttpPost]
        public ActionResult produtocadastro(model.produto model)
        {
            business.produtosbusiness bproduto = new business.produtosbusiness();
            bproduto.inserir(model);
            return View();
        }
        public ActionResult produtocadastro()
        {
            return View();
        }


        [HttpPost]
        public ActionResult vendacadastro(model.venda model)
        {
            business.vendasbusiness bvenda = new business.vendasbusiness();
            bvenda.inserir(model);
            return View();
        }
        public ActionResult vendacadastro()
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