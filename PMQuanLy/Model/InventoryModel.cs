using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace PMQuanLy.Model
{
    class InventoryModel:BaseModel
    {
        String table = "inventory";

        public DataTable getAllInventory() 
        {
            String select = " p.name, p.product_code, i.qr_code, i.weight, i.created_date";
            String where = "";
            String table_temp = "inventory i left join list_product p on i.product_code = p.product_code";
            SQLiteParameter[] arrValues = {};
            return selectQuery(select, table_temp, where, arrValues);
        }

        public DataTable getInventoryByQrCode(String qr_code)
        {
            String select = " qr_code, product_detail_id, weight, status";
            String where = "qr_code=@code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("qr_code", qr_code) };
            return selectQuery(select, table, where, arrValues);
        }

        public bool checkInventoryByQrCode(String qr_code)
        {
            String where = "qr_code=@qr_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("qr_code", qr_code) };
            return existQuery(table, where, arrValues);
        }
        public bool insertNewInventory(Hashtable arrCol)
        {
            bool result = false;
            result = insertQuery(table, arrCol);

            return result;

        }
    }
}
