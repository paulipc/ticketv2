using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketV2.Models;

namespace TicketV2.Controllers
{
    public class DetailsController : Controller
    {
        private ticketEntities db = new ticketEntities();

        // GET: Details
        public ActionResult Index(int? id)
        {
            //var detail = db.Detail.Include(d => d.Ticket);
            //var detail = db.Detail.Include(d => d.Ticket).(i => i.TicketID == id);
            var detail = from b in db.Detail
                         where b.TicketID == id
                         select b;
            return View(detail.ToList());
        }

        // GET: Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detail detail = db.Detail.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }

        // GET: Details/Create
        public ActionResult Create()
        {
            ViewBag.TicketID = new SelectList(db.Ticket, "TicketID", "UserID");
            return View();
        }

        // POST: Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetailID,TicketID,Created,UserID,DDescription")] Detail detail)
        {
            if (ModelState.IsValid)
            {
                db.Detail.Add(detail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TicketID = new SelectList(db.Ticket, "TicketID", "UserID", detail.TicketID);
            return View(detail);
        }

        // GET: Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detail detail = db.Detail.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            ViewBag.TicketID = new SelectList(db.Ticket, "TicketID", "UserID", detail.TicketID);
            return View(detail);
        }

        // POST: Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetailID,TicketID,Created,UserID,DDescription")] Detail detail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TicketID = new SelectList(db.Ticket, "TicketID", "UserID", detail.TicketID);
            return View(detail);
        }

        // GET: Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detail detail = db.Detail.Find(id);
            if (detail == null)
            {
                return HttpNotFound();
            }
            return View(detail);
        }

        // POST: Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Detail detail = db.Detail.Find(id);
            db.Detail.Remove(detail);
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
