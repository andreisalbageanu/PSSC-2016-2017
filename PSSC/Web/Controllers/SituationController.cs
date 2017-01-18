using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Text;
using System.Net;

namespace Web.Controllers
{
    public class SituationController : Controller
    {

        private Models.databaseEntities8 _db = new Models.databaseEntities8();
        public ActionResult Situatie()
        {

            return View(_db.Situation.ToList());

        }
        //Create
        public ActionResult CreateSituation()
        {

            return View();

        }
        [HttpPost]
        public ActionResult CreateSituation(Models.Situation model)
        {

            if (ModelState.IsValid)
            {
                _db.Situation.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Situatie");
            }
            return View(model);

        }

        //Edit
        public ActionResult EditSituation(int id)
        {
            Models.Situation model = _db.Situation.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditSituation(Models.Situation model)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(model).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Situatie");
            }
            return View(model);
        }






        //Delete
        public ActionResult DeleteSituation(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Situation model = _db.Situation.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSituation(int id)
        {
            Models.Situation model = _db.Situation.Find(id);
            _db.Situation.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Situatie");
        }

    }
}
