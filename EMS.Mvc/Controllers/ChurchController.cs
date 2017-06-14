using AutoMapper;
using EMS.Application.Registration;
using EMS.Domain.Entity;
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
        public ActionResult Edit(long? id)
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

        // GET: Church/Search/?parameter=search
        public ActionResult Search(string parameter)
        {
            if (string.IsNullOrEmpty(parameter))
                return RedirectToAction("Index");

            var filtered = ContainerFactory.Get<IChurchAppService>().ObtainBySearch(parameter.ToUpper()).ToList();

            ViewBag.Search = parameter;
            var churches = Mapper.Map<IEnumerable<Church>, IEnumerable<ChurchViewModel>>(filtered);

            return View("Index", churches);
        }
        //GET: Church/Create  
        public ViewResult Create()
        {
            return View("Edit", new ChurchViewModel());
        }

        //POST: Church/Edit
        [HttpPost]
        public ActionResult Save(ChurchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var modelDomain = Mapper.Map<ChurchViewModel, Church>(model);
                var validationResult = ContainerFactory.Get<IChurchAppService>().Save(modelDomain);

                if (validationResult.IsValid)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in validationResult.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

            }
            return View(model);
        }


        //POST: Church/Delete
        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (id == default(int))
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var domain = ContainerFactory.Get<IChurchAppService>().GetById(id);

            if (domain == null)
                return new HttpNotFoundResult();

            var validationResult = ContainerFactory.Get<IChurchAppService>().Delete(domain);
            var vm = Mapper.Map<Church, ChurchViewModel>(domain);

            if (validationResult.IsValid)
            {
                //ViewBag.Message = EnumHelper.GetEnumDescription(SuccessNotification.Message);
                vm = new ChurchViewModel();
                return PartialView("Edit", vm);
            }
            else
            {
                validationResult.Errors.ToList().ForEach(x => ModelState.AddModelError(string.Empty, x));
            }

            return PartialView("Edit", vm);
        }
    }

}
