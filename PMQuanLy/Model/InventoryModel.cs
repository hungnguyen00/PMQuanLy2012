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
            String where = "status=@status";
            String table_temp = "inventory i left join list_product p on i.product_code = p.product_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("status", 1) };
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
        public void insertInventoryList(DataTable dt)
        {
            Hashtable hInventory = new Hashtable();
            ListProductModel mListProduct = new ListProductModel();
            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                hInventory.Clear();
                hInventory.Add("qr_code", row["qr_code"].ToString());
                hInventory.Add("product_code", row["product_code"].ToString());
                hInventory.Add("weight", row["weight"].ToString());
                hInventory.Add("status", 1);

                //insert new inventory
                insertNewInventory(hInventory);

                //add quantity to product
                mListProduct.addQuantityByProductCode(row["product_code"].ToString());
            }
        }

        public bool insertNewInventory(Hashtable arrCol)
        {
            bool result = false;
            result = insertQuery(table, arrCol);
            return result;
        }
        public void updateInventoryByQrCode(String qr_code)
        {
            String where = "qr_code=@qr_code";
            SQLiteParameter[] arrValues = { new SQLiteParameter("qr_code", qr_code) };
            Hashtable hInventory = new Hashtable();
            hInventory.Add("status", 2);
            updateQuery(table, where, arrValues, hInventory);
        }
    }
}
