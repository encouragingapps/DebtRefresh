using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebtRefresh.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DebtRefresh.WebUI.Controllers
{
    public class CreditCardController : Controller 
    {
        // GET: CreditCard
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreditCard/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: CreditCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreditCard/Create
        [HttpPost]        
        public ActionResult Create([FromBody]CreditCardModel data)
        {
            try
            {
                                
                // THESE CODE ALWAYS RETURNS NULL DATA No matter what I try
                // Even passing in and individual field gives me null

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CreditCard/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: CreditCard/Edit/5
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

        // GET: CreditCard/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: CreditCard/Delete/5
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