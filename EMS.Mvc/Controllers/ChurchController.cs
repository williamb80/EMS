using AutoMapper;
using EMS.Application.Model.Interface;
using EMS.Application.Registration.Interface;
using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using EMS.Mvc.ViewModels.Registration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace EMS.Mvc.Model.Controllers
{
    public class ChurchController : Controller
    {
        // GET: Church
        public ActionResult Index()
        {
            var churches = Mapper.Map<IEnumerable<Church>, IEnumerable<ChurchViewModel>>(ContainerFactory.Get<IChurchAppService>().GetAll());
            return View(churches);
        }

        //GET: Church/Edit/5        
        public ActionResult Edit(long? id, bool? newPage)
        {
            if (id == decimal.Zero || id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var church = Mapper.Map<Church, ChurchViewModel>(ContainerFactory.Get<IChurchAppService>().GetById(id));

            if (church == null)
                return new HttpNotFoundResult();


            if (church.Representatives != null && church.Representatives.Any())
            {
                ViewBag.Representatives = church.Representatives.Select(r => new { r.Id, r.Name });
            }

            if (Request.IsAjaxRequest())
            {
                return PartialView(church);
            }

            return View(church);            
        }

        //GET: Church/Detail/5        
        public ActionResult Detail(long? id, bool? newPage)
        {
            if (id == decimal.Zero || id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var church = Mapper.Map<Church, ChurchViewModel>(ContainerFactory.Get<IChurchAppService>().GetById(id));

            if (church == null)
                return new HttpNotFoundResult();

            if (Request.IsAjaxRequest())
            {
                return PartialView(church);
            }

            return View(church);
        }

        //GET: Church/Create  
        public ViewResult Create()
        {
            var church = new ChurchViewModel();
            return View("Edit", church);
        }

        //POST: Church/Edit
        [HttpPost]
        public ActionResult Create(ChurchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var returnCreate = new ValidationResult();
                var modelDomain = Mapper.Map<ChurchViewModel, Church>(model);
                returnCreate = ContainerFactory.Get<IChurchAppService>().Save(modelDomain);

                if (returnCreate.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in returnCreate.Errors)
                    {
                        ModelState.AddModelError("", error.Message);
                    }
                }

            }
            return View(model);
        }

        //POST: Church/Edit
        [HttpPost]
        public ActionResult Edit(ChurchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var returnValidation = new ValidationResult();
                var modelDomain = Mapper.Map<ChurchViewModel, Church>(model);
                returnValidation = ContainerFactory.Get<IChurchAppService>().Save(modelDomain);

                if (returnValidation.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in returnValidation.Errors)
                    {
                        ModelState.AddModelError("", error.Message);
                    }
                }

            }
            return View(model);
        }


        //GET: Church/Delete/5        
        public ViewResult Delete(long id)
        {
            var church = ContainerFactory.Get<IChurchAppService>().GetById(id);
            return View(church);
        }

        //POST: Church/Delete
        [HttpPost]
        public ActionResult Delete(Church model)
        {
            if (ModelState.IsValid)
            {
                var returnValidation = new ValidationResult();
                returnValidation = ContainerFactory.Get<IChurchAppService>().Delete(model);

                if (returnValidation.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in returnValidation.Errors)
                    {
                        ModelState.AddModelError("", error.Message);
                    }
                }

            }
            return View(model);
        }


    }
}