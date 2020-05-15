using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoLvl3.Controllers
{
    public class SubTaskController : Controller
    {
        // GET: SubTask
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubTask/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubTask/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubTask/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubTask/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubTask/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubTask/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubTask/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}