using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HW1.Models
{
    public class Employees
    {
        public int EmployeeID { get; set; }
        [DisplayName("員工姓名")]
        public String LastName { get; set; }
        [DisplayName("員工姓名")]
        public String FirstName { get; set; }

        public List<Employees> GetEmployeesByCondition()
        {
            var EmployeesList = new List<Employees>()
           {
               new Employees{
                  EmployeeID=1,
                  LastName="小名",
                  FirstName="王"
               },
               new Employees{
                  EmployeeID=2,
                  LastName="曉華",
                  FirstName="黃"
               }
           };
            return EmployeesList;
        }
    }
}