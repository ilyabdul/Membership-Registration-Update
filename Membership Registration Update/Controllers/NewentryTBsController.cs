using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Membership_Registration_Update.Controllers
{
    public class NewentryTBsController : Controller
    {
        // GET: NewentryTBs
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewentryTBs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewentryTBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewentryTBs/Create
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

        // GET: NewentryTBs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewentryTBs/Edit/5
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

        // GET: NewentryTBs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewentryTBs/Delete/5
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
