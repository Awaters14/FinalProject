using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private ResponseContext context { get; set; }
        public HomeController(ResponseContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var respones = context.Respones.Include(m => m.priority).OrderBy(m => m.priorityId).ToList();
            return View(respones);
        }
        [HttpPost]
        public IActionResult Index(Response model)
        {
            ViewBag.response = model.printResponse();
            return View(model);
        }
    }
}
