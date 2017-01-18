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
    public class StudentController : Controller
    {


        private Models.databaseEntities8 _db = new Models.databaseEntities8();

        public ActionResult Studenti(string searchString)
        {

            return View(_db.Student.ToList());
            

        }
        //Create
        public ActionResult CreateStudent()
        {

            return View();

        }

        [HttpPost]
        public ActionResult CreateStudent(Models.Student model)
        {

            if (ModelState.IsValid)
            {

                _db.Student.Add(model);

                _db.SaveChanges();
                return RedirectToAction("Studenti");
            }
            return View(model);

        }
        //Edit
        public ActionResult EditStudent(int id)
        {
            Models.Student model = _db.Student.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditStudent(Models.Student model)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(model).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Studenti");
            }
            return View(model);
        }
        //Delete 
        public ActionResult DeleteStudent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Student model = _db.Student.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteStudent(int id)
        {
            Models.Student model = _db.Student.Find(id);
            _db.Student.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Studenti");
        }
        

        

    }
}
