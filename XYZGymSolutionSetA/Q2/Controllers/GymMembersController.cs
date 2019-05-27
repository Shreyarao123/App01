using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Q2.Models;

namespace Q2.Controllers
{
    public class GymMembersController : Controller
    {
        private M3SampleEntities db = new M3SampleEntities();
        List<GymMember> gym;
        // GET: GymMembers
        public ActionResult Get3Months()
        {
            gym = db.GymMembers.Where(x => x.MemberShipDuration == "3 Month").ToList();
            return View("Get3Months", gym);
        }
        public ActionResult Index()
        {
            return View(db.GymMembers.ToList());
        }

        // GET: GymMembers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymMember gymMember = db.GymMembers.Find(id);
            if (gymMember == null)
            {
                return HttpNotFound();
            }
            return View(gymMember);
        }

        // GET: GymMembers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GymMembers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberCode,MemberName,EmailId,PhoneNumber,MemberShipStartDate,MemberShipDuration")] GymMember gymMember)
        {
            if (ModelState.IsValid)
            {
                db.GymMembers.Add(gymMember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gymMember);
        }

        // GET: GymMembers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymMember gymMember = db.GymMembers.Find(id);
            if (gymMember == null)
            {
                return HttpNotFound();
            }
            return View(gymMember);
        }

        // POST: GymMembers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MemberCode,MemberName,EmailId,PhoneNumber,MemberShipStartDate,MemberShipDuration")] GymMember gymMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gymMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gymMember);
        }

        // GET: GymMembers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GymMember gymMember = db.GymMembers.Find(id);
            if (gymMember == null)
            {
                return HttpNotFound();
            }
            return View(gymMember);
        }

        // POST: GymMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GymMember gymMember = db.GymMembers.Find(id);
            db.GymMembers.Remove(gymMember);
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
