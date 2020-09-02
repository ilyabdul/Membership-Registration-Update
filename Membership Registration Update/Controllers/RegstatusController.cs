using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Membership_Registration_Update.Models;

namespace Membership_Registration_Update.Controllers
{
    public class RegstatusController : Controller
    {
        private NewRegistrationEntities1 db = new NewRegistrationEntities1();

        // GET: Regstatus
        public ActionResult Index()
        {
            return View(db.Regstatus.ToList());
        }

        // GET: Regstatus/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regstatu regstatu = db.Regstatus.Find(id);
            if (regstatu == null)
            {
                return HttpNotFound();
            }
            return View(regstatu);
        }

        // GET: Regstatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regstatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "statusId,Status_name,Refcode")] Regstatu regstatu)
        {
            if (ModelState.IsValid)
            {
                db.Regstatus.Add(regstatu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regstatu);
        }

        // GET: Regstatus/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regstatu regstatu = db.Regstatus.Find(id);
            if (regstatu == null)
            {
                return HttpNotFound();
            }
            return View(regstatu);
        }

        // POST: Regstatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "statusId,Status_name,Refcode")] Regstatu regstatu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regstatu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regstatu);
        }

        // GET: Regstatus/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Regstatu regstatu = db.Regstatus.Find(id);
            if (regstatu == null)
            {
                return HttpNotFound();
            }
            return View(regstatu);
        }

        // POST: Regstatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Regstatu regstatu = db.Regstatus.Find(id);
            db.Regstatus.Remove(regstatu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
