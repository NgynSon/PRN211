﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();

        public OrderDetailDAO()
        {
        }

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        //-------------------------------------------------------------
        public IEnumerable<OrderDetail> GetOrderDetailList(int orderId)
        {
            using FStoreContext dBContext = new FStoreContext();
            var orderDetail = dBContext.OrderDetails.Where(detail => detail.OrderId == orderId).ToList();
            return orderDetail;
        }

        //---------------------------------------------------------
        // tìm một thằng trong bảng orderDetail bằng id truyền vào
        public OrderDetail getDetailById(int orderId)
        {
            using FStoreContext dBContext = new FStoreContext();
            OrderDetail detail = dBContext.OrderDetails.Where(detail => detail.OrderId == orderId).FirstOrDefault();
            return detail;
        }

        //--------------------------------------------------------

        public OrderDetail getDetailByProductId(int productId)
        {
            using FStoreContext dBContext = new FStoreContext();
            OrderDetail detail = dBContext.OrderDetails.Where(detail => detail.ProductId == productId).FirstOrDefault();
            return detail;
        }


        public void AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {

                using FStoreContext dBContext = new FStoreContext();
                dBContext.OrderDetails.Add(orderDetail);
                dBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using FStoreContext dBContext = new FStoreContext();
                dBContext.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dBContext.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteOrderDetail(int orderId, int productId)
        {
            using FStoreContext dBContext = new FStoreContext();
            OrderDetail order = dBContext.OrderDetails.Where(order => order.OrderId == orderId && order.ProductId == productId).FirstOrDefault();
            dBContext.OrderDetails.Remove(order);
            dBContext.SaveChanges();
        }
    }
}
