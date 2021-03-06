﻿using System;
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
    public class HomeController : Controller
    {



        private Models.databaseEntities8 _db = new Models.databaseEntities8();

        //Professors Table

        public ActionResult Index()
        {

            return View(_db.Professor.ToList());

        }

        //Create
        public ActionResult CreateProfesor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProfesor(Models.Professor model)
        {
            if (ModelState.IsValid)
            {
                _db.Professor.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        //Edit
        public ActionResult EditProfessor(int id)
        {
            Models.Professor model = _db.Professor.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult EditProfessor(Models.Professor model)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(model).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //Delete

        public ActionResult DeleteProfessor(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Professor model = _db.Professor.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProfessor(int id)
        {
            Models.Professor model = _db.Professor.Find(id);
            _db.Professor.Remove(model);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }




        //Situation Table
       

        
    }

}
