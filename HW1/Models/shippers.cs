using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HW1.Models
{
    public class shippers
    {
        public int ShipperID { get; set; }
        [DisplayName("出貨公司")]
        public String CompanyName { get; set; }
        public String phone { get; set; }

        public List<shippers> GetShippersByCondition()
        {
            var ShippersList = new List<shippers>()
           {
               new shippers{
                  ShipperID=1,
                  CompanyName="黑貓宅急便",
                  phone="0800000000"
               },
               new shippers{
                  ShipperID=2,
                  CompanyName="白狗宅急便",
                  phone="0900000000"
               }
           };
            return ShippersList;
        }
    }
}