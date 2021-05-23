using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_OPRATION.DataBase;
using CRUD_OPRATION.Models;

namespace CRUD_OPRATION.Controllers
{
    public class studdataController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: studdata
        public ActionResult Index()
        {
            return View(db.studobj.ToList());
        }

        // GET: studdata/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.studobj.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // GET: studdata/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studdata/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,studname,department,city")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.studobj.Add(stud);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stud);
        }

        // GET: studdata/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.studobj.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // POST: studdata/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,studname,department,city")] Stud stud)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stud).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stud);
        }

        // GET: studdata/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stud stud = db.studobj.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }

        // POST: studdata/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stud stud = db.studobj.Find(id);
            db.studobj.Remove(stud);
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
