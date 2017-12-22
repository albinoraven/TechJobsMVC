using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchTerm, string searchType)
        {

            if (ViewBag.searchType(ViewBag.column.all) || ViewBag.searchType(""))
            {
                ViewBag.Jobs = JobData.FindByValue(ViewBag.Value);
            }
            else
            {
                ViewBag.Jobs = JobData.FindByColumnAndValue(ViewBag.Column, ViewBag.Value);
            }

            ViewBag.Title = "Search";

            return View("Index");
        }
        public IActionResult Results()
        {

        }
    }
}
