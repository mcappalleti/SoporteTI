﻿using SoporteTecnico.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoporteTecnico.Web.Controllers
{
    public class ProcuctosController : Controller
    {
        // GET: Procuctos
        public ActionResult Index()
        {

            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();     
            return View(listadeProductos);
        }
    }
}