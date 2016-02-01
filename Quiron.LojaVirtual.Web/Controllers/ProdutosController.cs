﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorios _repositorio;

        //
        // GET: /Produtos/
        public ActionResult Index()
        {
           _repositorio = new ProdutosRepositorios();
          var produtos = _repositorio.Produtos.Take(2);

          return View(produtos);
        }
	}
}