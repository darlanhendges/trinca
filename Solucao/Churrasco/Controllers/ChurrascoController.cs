using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Churrasco.Controllers
{
    public class ChurrascoController : Controller
    {
        // GET: Churrasco
        public ActionResult Index()
        {
            return View();
        }

        // GET: Churrasco/Details/5
        public ActionResult Details(int id)
        {
            if (id == null || id == 0)
            {
                RedirectToAction("Index", "Home");
            }

            var churrasco = new DAB.BO.Churrasco().BuscaPorID(id);

            if (churrasco == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            return View(churrasco);
        }

        // GET: Churrasco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Churrasco/Create
        [HttpPost]
        public ActionResult Create(DAB.DTO.Churrasco churrasco)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    new DAB.BO.Churrasco().Adiciona(churrasco);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(churrasco);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Erro", "Erro ao salvar o novo churrasco tchê: " + ex.Message);
                return View(churrasco);
            }
        }

        // GET: Churrasco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Churrasco/Edit/5
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

        // GET: Churrasco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Churrasco/Delete/5
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
