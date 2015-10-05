using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkNCInfoService.Mvc5.Models.WorkModels;

namespace WorkNCInfoService.Mvc5.Controllers
{
    public class WorkZoneController : Controller
    {
        WorkContext db = new WorkContext();
        // GET: WorkZone
        public ActionResult Index()
        {
            return View(db.WorkNC_WorkZone.ToList());
        }

        // GET: WorkZone/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WorkZone/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkZone/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkZone/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkZone/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkZone/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WorkZone/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
