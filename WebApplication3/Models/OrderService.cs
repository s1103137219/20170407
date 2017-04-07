using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class OrderService
    {
        public void InsertOrder(Models.Order order)
        {
        }
        public Models.Order GetOrderById(string orderId)
        {
            Models.Order result = new Order();
            result.CustId = "GSS";
            result.CustName = "叡揚資訊";
            return result;
        }
        public void DeleteOrderById(string orderId)
        {
        }
        public void UpdateOrder(Models.Order order)
        {
        }
        public List<Models.Order>GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order(){CustId="GSS",CustName="瑞陽資訊",EmpId=1,EmpName="小名",Orderdate=DateTime.Parse("2015/11/08")});
            result.Add(new Order(){CustId = "CNN", CustName = "AI資訊", EmpId = 1, EmpName = "大華", Orderdate = DateTime.Parse("2015/11/28") });
            return result;
        }


    }
}