using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class CargoController : Controller
    {
        //
        // GET: /Cargo/

        testappEntities entitis = new testappEntities();

        public ActionResult Index()
        {
            var listaCargo = entitis.cargo;
            return View(listaCargo.ToList());
        }

        public ActionResult ListadoMaestroCargos()
        {
            var listaCargos = entitis.cargo;
            return View(listaCargos.ToList());
        }

        public ActionResult UsuarioPorCargo(string cargo)
        {
            var modelo = from p in entitis.useario where p.cargo.car_des == cargo select p;
            return View(modelo.ToList());
        }

        public ActionResult ListaUsuarioDescrip()
        {
            var modelo = from p in entitis.useario
                         join c in entitis.cargo
                         on p.usu_cod equals c.car_cod

                         select new Usuario
                         {
                             codigo = p.usu_cod,
                             nombre = p.usu_nom,
                             cargo = c.car_des
                         };

            return View(modelo.ToList());
        }

    }
}
