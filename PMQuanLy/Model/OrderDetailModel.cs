using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace PMQuanLy.Model
{
    class OrderDetailModel:BaseModel
    {
        String table = "list_order_detail";

        public DataTable getOrderDetailByOrderId(String order_id) 
        {
            String select = " *";
            String where = "order_id=@order_id";
            SQLiteParameter[] arrValues = { new SQLiteParameter("order_id", order_id) };
            return selectQuery(select, table, where, arrValues);
        }

        public DataTable getOrderProductDetailByOrderId(String order_id)
        {
            String select = " od.product_code, count(od.product_code) as quantity, sum(od.weight) as weight, p.name  ";
            String table_temp = " list_order_detail od left join list_product p on od.product_code = p.product_code  ";
            String where = "od.order_id=@order_id";
            SQLiteParameter[] arrValues = { new SQLiteParameter("order_id", order_id) };
            String group_by = " GROUP BY od.product_code ";
            return selectQuery(select, table_temp, where, arrValues, group_by);
        }
        public bool insertNewOrderDetail(Hashtable arrCol)
        {
            bool result = false;
            result = insertQuery(table, arrCol);
            return result;
        }
    }
}
