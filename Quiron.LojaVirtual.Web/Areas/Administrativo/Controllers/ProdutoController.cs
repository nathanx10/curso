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

            return View(produto);
        }
    }
}