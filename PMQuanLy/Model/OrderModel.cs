using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace PMQuanLy.Model
{
    class OrderModel:BaseModel
    {
        String table = "list_order";

        public DataTable getAllOrder() 
        {
            String select = " *";
            String where = "";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table, where, arrValues);
        }
        public void saveOrder(DataTable dt, Hashtable htInput)
        {
            Hashtable htOrder = new Hashtable();
            Hashtable htOrderDetail = new Hashtable();
            htOrder.Add("total_quantity", htInput["total_quantity"].ToString());
            htOrder.Add("total_weight", htInput["total_weight"].ToString());
            htOrder.Add("customer_id", 1);

            //insert new order
            int order_id = insertNewOrder(htOrder);

            OrderDetailModel mOrderDetail = new OrderDetailModel();
            InventoryModel mInventory = new InventoryModel();
            foreach (DataRow row in dt.Rows)
            {
                htOrderDetail.Clear();
                htOrderDetail.Add("order_id", order_id);
                htOrderDetail.Add("product_code", row["product_code"]);
                htOrderDetail.Add("qr_code", row["qr_code"]);
                htOrderDetail.Add("weight", row["weight"]);

                //insert new order detail
                mOrderDetail.insertNewOrderDetail(htOrderDetail);

                //update status of inventory
                mInventory.updateInventoryByQrCode(row["qr_code"].ToString());
            }
        }

        public int insertNewOrder(Hashtable arrCol)
        {
            insertQuery(table, arrCol);
            return selectLastOrderId();
        }

        private int selectLastOrderId() 
        {
            String select = "max(order_id)";
            String where = "";
            SQLiteParameter[] arrValues = { };
            DataTable dtResult = selectQuery(select, table, where, arrValues);
            return Int32.Parse(dtResult.Rows[0][0].ToString());
        }
    }
}
