using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhiDeltZips.Models;

namespace PhiDeltZips.Controllers
{
    public class PlayersController : Controller
    {
        private PhiDeltZipsEntities db = new PhiDeltZipsEntities();

        // GET: Players
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerID,PlayerName,Y2010Points,Y2010Wins,Y2010Losses,Y2010Ties,Y2010Trades,Y2010Finish,Y2011Points,Y2011Wins,Y2011Losses,Y2011Ties,Y2011Trades,Y2011Finish,Y2012Points,Y2012Wins,Y2012Losses,Y2012Ties,Y2012Trades,Y2012Finish,Y2013Points,Y2013Wins,Y2013Losses,Y2013Ties,Y2013Trades,Y2013Finish,Y2014Points,Y2014Wins,Y2014Losses,Y2014Ties,Y2014Trades,Y2014Finish,Y2015Points,Y2015Wins,Y2015Losses,Y2015Ties,Y2015Trades,Y2015Finish,Y2016Points,Y2016Wins,Y2016Losses,Y2016Ties,Y2016Trades,Y2016Finish,Y2017Points,Y2017Wins,Y2017Losses,Y2017Ties,Y2017Trades,Y2017Finish,Y2018Points,Y2018Wins,Y2018Losses,Y2018Ties,Y2018Trades,Y2018Finish")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerID,PlayerName,Y2010Points,Y2010Wins,Y2010Losses,Y2010Ties,Y2010Trades,Y2010Finish,Y2011Points,Y2011Wins,Y2011Losses,Y2011Ties,Y2011Trades,Y2011Finish,Y2012Points,Y2012Wins,Y2012Losses,Y2012Ties,Y2012Trades,Y2012Finish,Y2013Points,Y2013Wins,Y2013Losses,Y2013Ties,Y2013Trades,Y2013Finish,Y2014Points,Y2014Wins,Y2014Losses,Y2014Ties,Y2014Trades,Y2014Finish,Y2015Points,Y2015Wins,Y2015Losses,Y2015Ties,Y2015Trades,Y2015Finish,Y2016Points,Y2016Wins,Y2016Losses,Y2016Ties,Y2016Trades,Y2016Finish,Y2017Points,Y2017Wins,Y2017Losses,Y2017Ties,Y2017Trades,Y2017Finish,Y2018Points,Y2018Wins,Y2018Losses,Y2018Ties,Y2018Trades,Y2018Finish")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
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
