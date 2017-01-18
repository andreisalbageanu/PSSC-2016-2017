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
    public class SubjectController : Controller
    {
       private Models.databaseEntities8 _db = new Models.databaseEntities8();
       public ActionResult Subjects()
            {

                return View(_db.Subject.ToList());

            }


            //Create

            public ActionResult CreateSubject()
            {

                return View();

            }
            [HttpPost]
            public ActionResult CreateSubject(Models.Subject model)
            {

                if (ModelState.IsValid)
                {
                    _db.Subject.Add(model);
                    _db.SaveChanges();
                    return RedirectToAction("Subjects");
                }
                return View(model);

            }

        //Edit
            public ActionResult EditSubject(int id)
            {
                Models.Subject model = _db.Subject.Find(id);
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }
            [HttpPost]
            public ActionResult EditSubject(Models.Subject model)
            {
                if (ModelState.IsValid)
                {
                    _db.Entry(model).State = EntityState.Modified;
                    _db.SaveChanges();
                    return RedirectToAction("Subjects");
                }
                return View(model);
            }

           
            



       //Delete
        public ActionResult DeleteSubject(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Subject model=_db.Subject.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSubject(int id)
        {
            Models.Subject model = _db.Subject.Find(id);
            _db.Subject.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Subjects");
        }

            

        

    }
}
