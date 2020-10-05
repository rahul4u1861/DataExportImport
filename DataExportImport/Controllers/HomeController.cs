using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataExportImport.Models;
using DataExportImport.Service;

namespace DataExportImport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Customer()
        {
            ViewBag.Message = "Your contact page.";
            //var exportDataintoJsonFile = new ExportDataintoJsonFile();
            //exportDataintoJsonFile.GenerateJsonFile(customer);
            return View();
        }

        public void Export(Customer customer)
        {
            var exportDataintoJsonFile = new ExportDataintoJsonFile();
            exportDataintoJsonFile.GenerateJsonFile(customer);
        }
        public ActionResult CustomerOwnedVehicle()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}