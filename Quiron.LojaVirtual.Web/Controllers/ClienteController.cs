using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        [Route("Teste")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Cliente";
            ViewBag.Action = "Index";
            return View();
        }

        [Route("Cliente/Adicionar/{usuario}/{id}")]
        public string Adicionar(string usuario, int id)
        {
            return string.Format("Usuario {0}, id {1}", usuario, id);
        }
    }
}