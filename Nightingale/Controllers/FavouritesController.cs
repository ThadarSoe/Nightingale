﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nightingale;

namespace Nightingale.Controllers
{
    public class FavouritesController : Controller
    {
        private NightingaleEntities1 db = new NightingaleEntities1();

        // GET: Favourites
        public ActionResult Index()
        {
            return View(db.Favourites.ToList());
        }

        // GET: Favourites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favourite favourite = db.Favourites.Find(id);
            if (favourite == null)
            {
                return HttpNotFound();
            }
            return View(favourite);
        }

        // GET: Favourites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Favourites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SessionID,Title,Category")] Favourite favourite)
        {
            if (ModelState.IsValid)
            {
                db.Favourites.Add(favourite);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(favourite);
        }

        // GET: Favourites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favourite favourite = db.Favourites.Find(id);
            if (favourite == null)
            {
                return HttpNotFound();
            }
            return View(favourite);
        }

        // POST: Favourites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SessionID,Title,Category")] Favourite favourite)
        {
            if (ModelState.IsValid)
            {
                db.Entry(favourite).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(favourite);
        }

        // GET: Favourites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favourite favourite = db.Favourites.Find(id);
            if (favourite == null)
            {
                return HttpNotFound();
            }
            return View(favourite);
        }

        // POST: Favourites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Favourite favourite = db.Favourites.Find(id);
            db.Favourites.Remove(favourite);
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
