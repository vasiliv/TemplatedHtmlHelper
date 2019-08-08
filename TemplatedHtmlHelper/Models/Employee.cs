using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TemplatedHtmlHelper.Models {
    public class Employee {
        public int Id { get; set; }
        [Display(Name = "Please enter your name: ")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsEmployee { get; set; }
        [Display(Name = "Date of birth: ")]
        //svavs kalendars
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        //svavs saatis chasacers
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}