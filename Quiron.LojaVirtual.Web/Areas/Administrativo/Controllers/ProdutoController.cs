using Quiron.LojaVirtual.Dominio.Entidades;
using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Areas.Administrativo.Controllers
{
    public class ProdutoController : Controller
    {
        ProdutosRepositorio _repositorio;
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.ToList();
            return View(produtos);
        }

        public ViewResult Alterar(int produtoId)
        {
            _repositorio = new  ProdutosRepositorio();
            Produto produto = _repositorio.Produtos
                .FirstOrDefault(p=>p.ProdutoId == produtoId);

            TempData["acao"] = "Alterar produto";

            return View(produto);
        }

        [HttpPost]
        public ActionResult Alterar(Produto produto)
        {
            if(ModelState.IsValid)
            {
                _repositorio = new ProdutosRepositorio();
                _repositorio.Salvar(produto);

                TempData["mensagem"] = string.Format("{0} foi salvo com sucesso", produto.Nome);

                return RedirectToAction("Index");
            }
            return View(produto);
        }

        public ViewResult NovoProduto()
        {
            TempData["acao"] = "Adicionar novo produto";
            return View("Alterar", new Produto());
        }

        [HttpPost]
        public ActionResult NovoProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _repositorio = new ProdutosRepositorio();
                _repositorio.Salvar(produto);

                TempData["mensagem"] = string.Format("{0} foi adicionado com sucesso", produto.Nome);
            }

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Excluir(int produtoId)
        //{
        //    _repositorio = new ProdutosRepositorio();
        //    Produto prod = _repositorio.Excluir(produtoId);

        //    if(prod != null)
        //    {
        //        TempData["mensagem"] = string.Format("{0} foi excluido com sucesso", prod.Nome);
        //    }

        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public JsonResult Excluir(int produtoId)
        {
            string mensagem = string.Empty;
            _repositorio = new ProdutosRepositorio();
            Produto prod = _repositorio.Excluir(produtoId);

            if (prod != null)
            {
                mensagem = string.Format("{0} foi excluido com sucesso", prod.Nome);
            }

            return Json(mensagem, JsonRequestBehavior.AllowGet);
        }
    }
}