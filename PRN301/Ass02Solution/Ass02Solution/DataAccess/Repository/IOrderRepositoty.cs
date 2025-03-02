﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepositoty
    {
        IEnumerable<Order> GetOrder();

        void InsertOrder(Order order);

        void UpdateOrder(Order order);

        Order GetOrderById(int orderId);

        void DeleteOrder(int orderId);

        Order GetOrderByMemberId(int memberId);

        IEnumerable<Order>? getOrderDetail(int memberId);

        IEnumerable<Order> GetSaleReportList(DateTime orderDate, DateTime shippedDate);
    }
}
