using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class ResponseController : Controller
    {
        private ResponseContext context { get; set; }

        public ResponseController(ResponseContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Priority = context.Priorities.OrderBy(p => p.priorityValue).ToList();
            return View("Edit", new Response());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Priority = context.Priorities.OrderBy(p => p.priorityValue).ToList();
            var response = context.Respones.Find(id);
            return View(response);
        }
        [HttpPost]
        public IActionResult Edit(Response response)
        {
            if (ModelState.IsValid)
            {
                if (response.ResponseId == 0) context.Respones.Add(response);
                else
                    context.Respones.Update(response); 
                    context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (response.ResponseId == 0) ? "Add" : "Edit";
                ViewBag.Priority = context.Priorities.OrderBy(p => p.priorityValue).ToList();
                ViewBag.Action = (response.ResponseId == 0) ? "Add" : "Edit"; return View(response);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Respones.Find(id); 
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Response response)
        {
            context.Respones.Remove(response); 
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
