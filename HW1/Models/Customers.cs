using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HW1.Models
{
    public class Customers
    {
        public int CustomerID { get; set; }
        [DisplayName("客戶名稱")]
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public String Address { get; set; }

        public List<Customers> GetCustomersByCondition()
        {
            var CustomersList = new List<Customers>()
           {
               new Customers{
                  CustomerID=1,
                  CompanyName="柯柯",
                  ContactName="柯先生",
                  Address="高雄市鼓山區"
               },
               new Customers{
                  CustomerID =2,
                  CompanyName="柴柴",
                  ContactName="柴先生",
                  Address="高雄市鳳山區"
               }
           };
            return CustomersList;
        }
    }
}