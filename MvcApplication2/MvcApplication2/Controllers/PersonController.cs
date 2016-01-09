using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/

        public ActionResult Index()
        {
            List<Person> lista= new List<Person>();

            Person per1 = new Person();
            per1.codigo = 1;
            per1.nombre = "Diego";
            per1.apepat = "Rueda";
            per1.apemat = "Mendoza";
            lista.Add(per1);

            Person per2 = new Person();
            per2.codigo = 2;
            per2.nombre = "Jeann";
            per2.apepat = "Rueda3";
            per2.apemat = "Mendoza2";
            lista.Add(per2);

            Person per3 = new Person();
            per3.codigo = 3;
            per3.nombre = "Diego3";
            per3.apepat = "Rueda3";
            per3.apemat = "Mendoza3";
            lista.Add(per3);

            return View(lista);
        }

    }
}
