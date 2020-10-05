using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpPost]
        public ActionResult Customer(Customer customer)
        {
            var dbContext = new DbContext();
            dbContext.save(customer);
            return View();
        }

        [HttpPost]
        public void Import(HttpPostedFileBase postedFile)
        {
            var customers = new List<Customer>();
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                //Read the content of Json file.
                string jsonData = System.IO.File.ReadAllText(filePath);

            }
        }
    }
}