﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace eSalex.Models
{
    /// <summary>
    /// 資料服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
		/// 取得DB連線字串
		/// </summary>
		/// <returns></returns>
		private string GetDBConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrder(Models.Order order) {
            
        }


        /// <summary>
        /// 刪除訂單
        /// </summary>
        /// <param name="id">訂單id</param>
        public void DeleteOrderById(string id) { }


        /// <summary>
        /// 更新訂單
        /// </summary>
        /// <param name="id">訂單id</param>
        public void UpdateOrderById(string id) { }


        /// <summary>
        /// 取得訂單資訊
        /// </summary>
        /// <param name="id">訂單id</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id) {
            Models.Order order = new Models.Order();
            order.CustId = "87";
            order.CustName = "魯蛋";

            return order;
        }

        /// <summary>
        /// 取得訂單資訊
        /// </summary>
        /// <typeparam name="GetOrderByCondition">篩選條件</typeparam>
        public List<Models.Order> GetOrderByCondition() {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustId = "001", CustName = "叡揚資訊", EmpId = 1, EmpName = "王小明", Orderdate = DateTime.Parse("2015/11/08") });
            result.Add(new Order() { CustId = "002", CustName = "叡揚資訊", EmpId = 1, EmpName = "王大明", Orderdate = DateTime.Parse("2016/11/08") });


            return result;
        }

        public DataTable TsetDBConn()
        {
            
                DataTable dt = new DataTable();
                string sql = @"SELECT CustomerID FROM Sales.Orders WHERE OrderID = @OrderID ";
                using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@OrderID", 10248));
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                    sqlAdapter.Fill(dt);
                    conn.Close();
                }
                return dt;

            
        }

    }
}