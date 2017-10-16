using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ManyToMany.Models
{
    public class MovieController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Movie
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            MoviesVM moviesvm = new MoviesVM();
            moviesvm.Id = id.Value;
            moviesvm.Name = movie.Name;

            List<ActorSelectorVM> actorselectorvm = new List<ActorSelectorVM>();

            var result = from a in db.Actors
                         where
                         (from m in db.MovieActors
                          where m.ActorId == a.Id && m.MovieId == id
                          select m.ActorId).Contains(a.Id)

                         select a;

            foreach (var item in result)
            {
                ActorSelectorVM asel = new ActorSelectorVM();
                asel.Id = item.Id;
                asel.Name = item.Name;
                asel.SurName = item.SurName;
                asel.DisplayName = String.Format("{0} {1}", asel.Name, asel.SurName);
                actorselectorvm.Add(asel);
            }

            moviesvm.Actors = actorselectorvm;

            return View(moviesvm);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            MoviesVM moviesvm = new MoviesVM();
            moviesvm.Id = id.Value;
            moviesvm.Name = movie.Name;

            List<ActorSelectorVM> actorselectorvm = new List<ActorSelectorVM>();

            var result = from a in db.Actors
                         select new 
                         {
                             a.Id,a.Name, 
                             a.SurName, 
                             Checked = ((from m in db.MovieActors
                              where m.ActorId == a.Id && m.MovieId == id
                              select m).Count() > 0)
                         };

            foreach (var item in result)
            {
                ActorSelectorVM asel = new ActorSelectorVM();
                asel.Id = item.Id;
                asel.Name = item.Name;
                asel.SurName = item.SurName;
                asel.Checked = item.Checked;
                asel.DisplayName = String.Format("{0} {1}", asel.Name, asel.SurName);
                actorselectorvm.Add(asel);
            }

            moviesvm.Actors = actorselectorvm;

            return View(moviesvm);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MoviesVM movie)
        {
            if (ModelState.IsValid)
            {

                // borrar MovieActors where MovieId == movie.Id
                var query = from m in db.MovieActors
                            where m.MovieId == movie.Id
                            select m;

                foreach (var item in query)
                {
                    db.Entry(item).State = EntityState.Deleted;
                }

                foreach (var item in movie.Actors)
                {
                    if (item.Checked)
                    {
                        db.MovieActors.Add(new MovieActors() { ActorId = item.Id, MovieId = movie.Id });
                    }
                }
                //db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
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
