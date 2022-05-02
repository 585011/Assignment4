using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookRoom.Models;

namespace BookRoom.Controllers
{
    public class BookingsController : Controller
    {
        private oblig4Entities9 db = new oblig4Entities9();

        public Rooms first = new Rooms();

        // GET: Bookings
        public ActionResult Index()

        {
            var bookings = db.Bookings.Include(b => b.Rooms).Include(b => b.Customers);
            return View(bookings.ToList());
        }

        // GET: Bookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookings bookings = db.Bookings.Find(id);
            if (bookings == null)
            {
                return HttpNotFound();
            }
            return View(bookings);
        }

        // GET: Bookings/Create

        public ActionResult Create()
        {
            dynamic mymodel = new ExpandoObject();
            ViewBag.RoomsID = new SelectList(db.Rooms.Select(i => i.RoomsID).Select(n => new { RoomsID = n }).First().ToString(), "RoomsID", "RoomsID");
            ViewBag.Beds = new SelectList(db.Rooms.Select(i => i.beds).Distinct().Select(n => new { beds = n }).ToList(), "Beds", "Beds");
            ViewBag.Rooms = db.Rooms;
            ViewBag.Size = new SelectList(db.Rooms.Select(i => i.size).Distinct().Select(n => new { size = n}).ToList(), "size", "size");
            ViewBag.username = new SelectList(db.Customers, "CustomersID", "CustomersID");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection form, [Bind(Include = "Beds,Rooms,BookingsID,roomID,username,bookingfrom,bookingto,checkedin,checkedout")] Bookings bookings)
        {
            string størrelse = form["size"];
            string senger = form["Beds"];

            int siz = int.Parse(størrelse);
            int Bed = int.Parse(senger);

            var fin = db.Rooms.Where(x => x.size == siz && x.beds == Bed);

            first = fin.First();


            if (ModelState.IsValid)
            {
                int a = first.RoomsID;
                bookings.roomID = a;
                db.Bookings.Add(bookings);  
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.roomID = new SelectList(db.Rooms.Select(i => i.RoomsID), "RoomsID", "RoomsID", bookings.roomID);
            ViewBag.username = new SelectList(db.Customers, "CustomersID", "pass", bookings.username);
            return View(bookings);
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookings bookings = db.Bookings.Find(id);
            if (bookings == null)
            {
                return HttpNotFound();
            }
            ViewBag.roomID = new SelectList(db.Rooms, "RoomsID", "RoomsID", bookings.roomID);
            ViewBag.username = new SelectList(db.Customers, "CustomersID", "pass", bookings.username);
            return View(bookings);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingsID,roomID,username,bookingfrom,bookingto,checkedin,checkedout")] Bookings bookings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.roomID = new SelectList(db.Rooms, "RoomsID", "RoomsID", bookings.roomID);
            ViewBag.username = new SelectList(db.Customers, "CustomersID", "pass", bookings.username);
            return View(bookings);
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bookings bookings = db.Bookings.Find(id);
            if (bookings == null)
            {
                return HttpNotFound();
            }
            return View(bookings);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bookings bookings = db.Bookings.Find(id);
            db.Bookings.Remove(bookings);
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
