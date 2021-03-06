using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Task21;

namespace Task21.Controllers
{
    public class DeptController : Controller
    {
        private demomvcEntities db = new demomvcEntities();

        // GET: /Dept/
        public ActionResult Index()
        {
            return View(db.tblDepartments.ToList());
        }

        // GET: /Dept/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDepartment tbldepartment = db.tblDepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // GET: /Dept/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Dept/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name")] tblDepartment tbldepartment)
        {
            if (ModelState.IsValid)
            {
                db.tblDepartments.Add(tbldepartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbldepartment);
        }

        // GET: /Dept/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDepartment tbldepartment = db.tblDepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // POST: /Dept/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name")] tblDepartment tbldepartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbldepartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbldepartment);
        }

        // GET: /Dept/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblDepartment tbldepartment = db.tblDepartments.Find(id);
            if (tbldepartment == null)
            {
                return HttpNotFound();
            }
            return View(tbldepartment);
        }

        // POST: /Dept/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblDepartment tbldepartment = db.tblDepartments.Find(id);
            db.tblDepartments.Remove(tbldepartment);
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
