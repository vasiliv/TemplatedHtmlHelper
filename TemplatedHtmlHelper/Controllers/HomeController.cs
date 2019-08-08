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
        public ActionResult Edit() {            
            return View();
        }
        [HttpPost]
        //Press me buttonis dacheris shemdeg aq shemova monacemebi Employee emp-is saxit
        public ActionResult Edit(Employee emp) {
            return View(emp);
        }
    }
}