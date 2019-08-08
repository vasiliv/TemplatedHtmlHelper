using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlHelper.Models;

namespace TemplatedHtmlHelper.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            Employee emp = new Employee() {
                Id = 1,
                Email = "Georgia@gmail.com",
                Name = "Vasil",
                IsEmployee = true,
                DateOfBirth = DateTime.Now
            };

            return View(emp);
        }
    }
}