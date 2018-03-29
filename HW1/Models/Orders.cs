using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;



namespace HW1.Models
{
    public class Orders
    {
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        [DisplayName("訂購日期")]
        public DateTime OrderDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime RequiredDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime ShippedDate { get; set; }
        public int ShippedID { get; set; }
        [DisplayName("運費")]
        public Decimal Freight { get; set; }
        [DisplayName("出貨地址")]
        public String ShipAddress { get; set; }
        [DisplayName("出貨城市")]
        public String ShipCity { get; set; }
        [DisplayName("出貨地區")]
        public String ShipRegion { get; set; }
        [DisplayName("郵遞區號")]
        public String ShipPostalCode { get; set; }
        [DisplayName("出貨國家")]
        public String ShipCountry { get; set; }

        public List<Orders> GetOrderByCondition()
        {
            var OrdersList = new List<Orders>()
           {
               new Orders{
                   OrderID=1,
                   CustomerID=1,
                   EmployeeID=1,
                   OrderDate=Convert.ToDateTime("2018-03-29"),
                   RequiredDate=Convert.ToDateTime("2018-03-29"),
                   ShippedDate=Convert.ToDateTime("2018-03-29"),
                   ShippedID=1,
                   Freight=50,
                   ShipAddress="中山路489巷1號",
                   ShipCity="高雄市",
                   ShipRegion="大社區",
                   ShipPostalCode="326",
                   ShipCountry="台灣"
               },
               new Orders{
                   OrderID=2,
                   CustomerID=1,
                   EmployeeID=2,
                   OrderDate=Convert.ToDateTime("2018-03-29"),
                   RequiredDate=Convert.ToDateTime("2018-03-29"),
                   ShippedDate=Convert.ToDateTime("2018-03-29"),
                   ShippedID=1,
                   Freight=50,
                   ShipAddress="深中路8號",
                   ShipCity="高雄市",
                   ShipRegion="燕巢區",
                   ShipPostalCode="326",
                   ShipCountry="台灣"
               }
           };
           return OrdersList;
        }
    }

}