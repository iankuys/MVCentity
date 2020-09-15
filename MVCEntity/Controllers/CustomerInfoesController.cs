using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCEntity.Models;

namespace MVCEntity.Controllers
{
    public class CustomerInfoesController : Controller
    {
        private ShoppingContext db = new ShoppingContext();

        // GET: CustomerInfoes
        public ActionResult Index()
        {
            return View(db.CustomerInfos.ToList());
        }

        // GET: CustomerInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = db.CustomerInfos.Find(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // GET: CustomerInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,FirstName,LastName,Age,Address,birthdate")] CustomerInfo customerInfo)
        {
            if (ModelState.IsValid)
            {
                db.CustomerInfos.Add(customerInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerInfo);
        }

        // GET: CustomerInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = db.CustomerInfos.Find(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // POST: CustomerInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,FirstName,LastName,Age,Address,birthdate")] CustomerInfo customerInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerInfo);
        }

        // GET: CustomerInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = db.CustomerInfos.Find(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // POST: CustomerInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerInfo customerInfo = db.CustomerInfos.Find(id);
            db.CustomerInfos.Remove(customerInfo);
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
