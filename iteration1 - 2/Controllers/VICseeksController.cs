using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using iteration1___2.Models;

namespace iteration1___2.Controllers
{
    public class VICseeksController : Controller
    {
        private VICseek_Model db = new VICseek_Model();

        // GET: VICseeks
        public ActionResult Index()
        {
            return View(db.VICseeks.ToList());
        }

        // GET: VICseeks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VICseek vICseek = db.VICseeks.Find(id);
            if (vICseek == null)
            {
                return HttpNotFound();
            }
            return View(vICseek);
        }

        // GET: VICseeks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VICseeks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,category,city,company_name,geo,iob_board,iob_title,iob_type,post_date,state_1,url_1")] VICseek vICseek)
        {
            if (ModelState.IsValid)
            {
                db.VICseeks.Add(vICseek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vICseek);
        }

        // GET: VICseeks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VICseek vICseek = db.VICseeks.Find(id);
            if (vICseek == null)
            {
                return HttpNotFound();
            }
            return View(vICseek);
        }

        // POST: VICseeks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,category,city,company_name,geo,iob_board,iob_title,iob_type,post_date,state_1,url_1")] VICseek vICseek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vICseek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vICseek);
        }

        // GET: VICseeks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VICseek vICseek = db.VICseeks.Find(id);
            if (vICseek == null)
            {
                return HttpNotFound();
            }
            return View(vICseek);
        }

        // POST: VICseeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VICseek vICseek = db.VICseeks.Find(id);
            db.VICseeks.Remove(vICseek);
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
