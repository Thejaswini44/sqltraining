using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorialCoreApp.Models;
namespace TutorialCoreApp.Controllers
{
    public class TutorialController : Controller
    {
        TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;
        }
        public IActionResult Index()
        {
            var tutorialList = _tutorialDbContext.tutorial.ToList();//select * from tutorial
            return View(tutorialList);
        }
        public IActionResult TutorialEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TutorialEntry(Tutorial tutorial)
        {
            _tutorialDbContext.tutorial.Add(tutorial);//insert into tutorial values(tutorial.id,tutorial.name,tutorial.dec,tutorial.published,tutorial.fees)
            _tutorialDbContext.SaveChanges();
            //ViewBag,viewdata,tempdata
            ViewBag.message = "Tutorial details saved successfully";
            return View();
        }

        public IActionResult EditTutorial(int TutorialId)
        {
            return View();
        }
        public IActionResult DeleteTutorial(int TutorialId)
        {
            return View();
        }
    }
}