using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        #region [AutoFac注入]

        readonly IStudentRepository repository;
        //构造器注入
        public HomeController(IStudentRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// AutoFac注入
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentIndex()
        {
            var data = repository.GetAll();
            return View(data);
        }
        #endregion
    }
}
