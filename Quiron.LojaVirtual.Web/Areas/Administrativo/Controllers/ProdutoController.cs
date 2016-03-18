﻿using Quiron.LojaVirtual.Dominio.Entidades;
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
    }
}