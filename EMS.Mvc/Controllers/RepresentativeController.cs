﻿using AutoMapper;
using EMS.Application.Registration;
using EMS.Domain.Entity;
using EMS.Framework.Core.DependencyInjection;
using EMS.Mvc.ViewModels.Registration;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EMS.Mvc.Controllers
{
    public class RepresentativeController : Controller
    {
        // GET: Representative
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            var representative = Mapper.Map<IEnumerable<Representative>, IEnumerable<RepresentativeViewModel>>(ContainerFactory.Get<IRepresentativeAppService>().GetAll());
            return Json(representative, JsonRequestBehavior.AllowGet);
        }

        // GET: Representative/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Representative/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Representative/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Representative/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Representative/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Representative/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Representative/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
