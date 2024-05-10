using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson03_NHM.Controllers
{
    public class NHMStudentController : Controller
    {
        // GET: NHMStudent
        public ActionResult Index()
        {
            //Du lieu tu ViewData
            ViewData["msg"] = "View Data - Ngo Hoang Minh";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            //Su Dung ViewBag
            //Luu tru gia tri don
            ViewBag.titleName = "Danh sach Hoc Vien - Ngo Hoang Minh";
            //Gia tri la 1 tap hop
            string[] names = { "Long ka ng", "Khac Duy", "Minh Lam" };
            ViewBag.list = names;
            //Gia tri la 1 doi tuong
            var obj = new
            {
                ID = 100,
                Name = "Minh NGo",
                Age = 18
            };
        ViewBag.student = obj;
            return View();
            
        }
        public ActionResult Insert()
        {
            return View("AddStudent");        
        }

    }
}