using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;

namespace MvcApplication4.Controllers
{
    public class AreaController : Controller
    {
        //
        // GET: /Area/
        public AreaModel model = new AreaModel();

        public ActionResult Index()
        {
            return View(model.ListarAreas());
        }

        public ActionResult Details(int id)
        {
            var area = model.buscarArea(id);
            return View(area);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(area a)
        {
            try
            {
                if (model.insertaArea(a).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");   
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var area = model.buscarArea(id);
            return View(area);
        }

        [HttpPost]
        public ActionResult Edit(int id, area a) {
            try
            {
                area area = new area();
                area.are_cod = id;
                area.are_des = a.are_des;

                if (model.ActualizarArea(area).Equals("Ok"))
                {
                    return RedirectToAction("Index");
                }
                else {
                    return RedirectToAction("Edit");
                }
            }
            catch 
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var area = model.buscarArea(id);
            return View(area);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection val) {
            try
            {
                if (model.EliminarArea(id).Equals("Ok"))
                {
                    return RedirectToAction("Index");
                }
                else {
                    return RedirectToAction("Delete");
                }
            }
            catch 
            {
                return View();
            }

        }

    }
}
