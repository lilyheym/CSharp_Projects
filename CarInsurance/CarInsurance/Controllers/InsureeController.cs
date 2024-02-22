using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Base Quote
                decimal monthlyQuote = 50;

                // Age variable (note to self: probably shouldn't make a habit of using variable instead of like, factor for obvious reasons)
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age < 18)
                    monthlyQuote += 100;
                else if (age >= 19 && age <= 25)
                    monthlyQuote += 50;
                else
                    monthlyQuote += 25;

                // Car Year variable
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                    monthlyQuote += 25;

                // Car Make Variable
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    monthlyQuote += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                        monthlyQuote += 25;
                }

                // Speeding Tickets variable
                monthlyQuote += insuree.SpeedingTickets * 10;

                // DUI variable
                if (insuree.DUI)
                    monthlyQuote *= 1.25m; // note to self: 25% increase

                // Full Coverage variable
                if (insuree.CoverageType)
                    monthlyQuote *= 1.5m; // 50% increase

                insuree.Quote = monthlyQuote;

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        // GET: Insuree/Admin
        [AuthorizeAdminController] // Custom filter to check if admin is logged in, I did look up how to do this
        public ActionResult Admin()
        {
            // Retrieve session variable
            var isAdminLoggedIn = Session["AdminLoggedIn"];

            var quotes = db.Insurees.ToList();
            return View(quotes);
        }

        // GET: /InsureeLogin
        public ActionResult Login()
        {
            return View();
        }

        // POST: Insuree/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "adminpassword")
            {
                Session["AdminLoggedIn"] = true; // Mark admin as logged in
                return RedirectToAction("Admin"); // Redirect to admin page
            }

            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }
    }
}
