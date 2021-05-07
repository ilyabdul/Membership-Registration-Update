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
    public class NewentryTBsController : Controller
    {
        private NewRegistrationEntities1 db = new NewRegistrationEntities1();

        // GET: NewentryTBs
        public ActionResult Index()
        {
            //var newentryTBs = db.NewentryTB.Include(n => n.Regstatu);
            var newentry = db.NewentryTBs.Include(n => n.Regstatu);
            return View(newentry.ToList());
        }

        // GET: NewentryTBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewentryTB newentryTB = db.NewentryTBs.Find(id);
            if (newentryTB == null)
            {
                return HttpNotFound();
            }
            return View(newentryTB);
        }

        // GET: NewentryTBs/Create
        public ActionResult Create()
        {
            ViewBag.Status = new SelectList(db.Regstatus, "statusId", "Status_name");
            return View();
        }

        // POST: NewentryTBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Reference_No,FullName,Date_Printed,Date_Approved,RegID,Status,Remark")] NewentryTB newentryTB)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.NewentryTBs.Add(newentryTB);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                ModelState.AddModelError("", ex.Message);
            }

            ViewBag.Status = new SelectList(db.Regstatus, "status_name", "Status_name", newentryTB.Status);
            return View(newentryTB);
        }

        // GET: NewentryTBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewentryTB newentryTB = db.NewentryTBs.Find(id);
            if (newentryTB == null)
            {
                return HttpNotFound();
            }
            ViewBag.Status = new SelectList(db.Regstatus, "statusId", "Status_name", newentryTB.Status);
            return View(newentryTB);
        }

        // POST: NewentryTBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Reference_No,FullName,Date_Printed,Date_Approved,RegID,Status,Remark")] NewentryTB newentryTB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newentryTB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Status = new SelectList(db.Regstatus, "statusId", "Status_name", newentryTB.Status);
            return View(newentryTB);
        }

        // GET: NewentryTBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewentryTB newentryTB = db.NewentryTBs.Find(id);
            if (newentryTB == null)
            {
                return HttpNotFound();
            }
            return View(newentryTB);
        }

        // POST: NewentryTBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewentryTB newentryTB = db.NewentryTBs.Find(id);
            db.NewentryTBs.Remove(newentryTB);
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
