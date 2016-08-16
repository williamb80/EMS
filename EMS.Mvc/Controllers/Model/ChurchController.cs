using AutoMapper;
using EMS.Application.Interface;
using EMS.Domain.Entity;
using EMS.Framework.Core.Common.Validation;
using EMS.Framework.Core.DependencyInjection;
using EMS.Mvc.ViewModels.Model;
using EMS.Resource.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EMS.Mvc.Model.Controllers
{
    public class ChurchController : Controller
    {
        // GET: Church
        public ActionResult Index()
        {
            var churches = Mapper.Map<IEnumerable<Church>, IEnumerable<ChurchVM>>(ContainerFactory.Get<IChurchAppService>().GetAll());
            ViewBag.Church = ChurchResource.Church;
            return View(churches);
        }

        //GET: Church/Edit/5        
        public ViewResult Edit(long id)
        {
            if (id == decimal.Zero)
            {
                //return PageNotFound
            }
            var church = Mapper.Map<Church, ChurchVM>(ContainerFactory.Get<IChurchAppService>().GetById(id));
            ViewBag.Detail = false;
            return View("Edit", church);
        }

        //GET: Church/Detail/5        
        public ViewResult Detail(long id)
        {
            var church = Mapper.Map<Church, ChurchVM>(ContainerFactory.Get<IChurchAppService>().GetById(id));
            ViewBag.Detail = true;
            return View("Edit", church);
        }

        //GET: Church/Create  
        public ViewResult Create()
        {
            var church = new ChurchVM();
            ViewBag.Detail = false;
            return View("Edit", church);
        }

        //POST: Church/Edit
        [HttpPost]
        public ActionResult Edit(ChurchVM model)
        {
            if (ModelState.IsValid)
            {
                var returnValidation = new ValidationResult();
                var modelDomain = Mapper.Map<ChurchVM, Church>(model);
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

        //VERIFICAR ESSA IDÉIA DE REAPROVEITAMENTO DE VIEW DA CERTA DE ACORDO COM A URL, 
        //SE NÃO DESFAZER E MANTER O PADRÃO DE VÁRIAS VIEWS

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